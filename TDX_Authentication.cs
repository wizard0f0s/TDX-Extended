using System;
using System.Net;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Web;
using TeamDynamix.Api;


namespace TDX_Extended
{

    internal class TDX_Login
    {
        public string username { get; set; }
        public string password { get; set; }

        public TDX_Login(string user, string pass)
        {
            username = user;
            password = pass;
        }
    }

    internal class TDX_Admin
    {
        public string BEID { get; set; }
        public string WebServicesKey { get; set; }

        public TDX_Admin(string id, string key)
        {
            BEID = id;
            WebServicesKey = key;
        }
    }

    public class JWT
    {
        public string token { get; set; }
    }


    internal class TDX_Authentication
    {
        private string _token { get; set; }
        private string _website { get; set; }
        private string _tdx_BEID = "";
        private string _tdx_WebServicesKey = "";
        private bool _tdx_isAdmin = false;
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly TDX_Login _tdxLogin;
        private readonly TDX_Admin _tdxAdmin;
        private TDX_APIRateLimit _loginAsyncRateLimit;
        private int _loginAsyncMaxCalls;
        private int _loginAsyncTimePeriod; //seconds
        private TDX_APIRateLimit _loginAdminAsyncRateLimit;
        private int _loginAdminAsyncMaxCalls;
        private int _loginAdminAsyncTimePeriod; //seconds
        private TDX_APIRateLimit _getUserAsyncRateLimit;
        private int _getUserAsyncMaxCalls;
        private int _getUserAsyncTimePeriod; //seconds
        private Logger _myLogger;


        private TDX_Authentication(string site)
        {
            _website = site;
            _token = "";
            _httpClient.BaseAddress = new Uri(_website);
            _loginAsyncMaxCalls = 60;
            _loginAsyncTimePeriod = 60;
            _loginAsyncRateLimit = new TDX_APIRateLimit(_loginAsyncMaxCalls, _loginAsyncTimePeriod);
            _loginAdminAsyncMaxCalls = 60;
            _loginAdminAsyncTimePeriod = 60;
            _loginAdminAsyncRateLimit = new TDX_APIRateLimit(_loginAdminAsyncMaxCalls, _loginAdminAsyncTimePeriod);
            _getUserAsyncMaxCalls = 60;
            _getUserAsyncTimePeriod = 60;
            _getUserAsyncRateLimit = new TDX_APIRateLimit(_getUserAsyncMaxCalls, _getUserAsyncTimePeriod);
        }

        public TDX_Authentication(Logger logger, string site, string user, string pass)
            : this(site)
        {
            _myLogger = logger;
            _tdxLogin = new TDX_Login(user, pass);
        }

        public TDX_Authentication(Logger logger, string site, string beid, string webServicesKey, bool isAdmin)
            : this(site)
        {
            _myLogger = logger;
            _tdx_isAdmin = isAdmin;
            _tdxAdmin = new TDX_Admin(beid, webServicesKey);
        }

        public async Task<string> LoginAsync(HttpClient httpClient)
        {
            var success = false;

            while (!success)
            {
                await _loginAsyncRateLimit.CheckRateLimit(_myLogger);

                var data = JsonSerializer.Serialize(_tdxLogin);
                var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage result = await httpClient.PostAsync(httpClient.BaseAddress + "/api/auth/login", content);
                _token = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    _myLogger.Message("TEST FAILED:\n\n" +
                        "TDX_Authentication:LoginAsync Error: " +
                        "\n\nStatusCode= " + result.StatusCode + 
                        ",\n\nReasonPhrase= " + result.ReasonPhrase + "." +
                        "\n\nResponse content = " + _token);
                } else
                {
                    _myLogger.Message("Authentication SUCCEEDED!");

                    return _token;
                }
            }
            return "";
        }


        public async Task<string> LoginAdminAsync(HttpClient httpClient)
        {
            await _loginAdminAsyncRateLimit.CheckRateLimit(_myLogger);

            var data = JsonSerializer.Serialize(_tdxAdmin);
            var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = await httpClient.PostAsync(httpClient.BaseAddress + "/api/auth/loginadmin", content);
            _token = result.Content.ReadAsStringAsync().Result;

            if (!result.IsSuccessStatusCode)
            {
                _myLogger.Message("TEST FAILED:\n\n" +
                   "TDX_Authentication:LoginAdminAsync Error: " +
                   "\n\nStatusCode= " + result.StatusCode + 
                   ",\n\n ReasonPhrase= " + result.ReasonPhrase + "." +
                   "\n\nResponse content = " + _token);

                _token = await LoginAdminAsync(httpClient);
            }
            else
            {
                _myLogger.Message("Authentication SUCCEEDED!");
            }
            return _token;
        }


        public async Task getUserAsync(HttpClient httpClient)
        {
            await _getUserAsyncRateLimit.CheckRateLimit(_myLogger);

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            HttpResponseMessage response = await httpClient.GetAsync(httpClient.BaseAddress + "/api/auth/getuser");
            string stringData = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                _myLogger.Message("TEST FAILED:\n\n" +
                    "TDX_Authentication:LoginAdminTestAsync Error: StatusCode= " +
                    response.StatusCode +
                    ", ReasonPhrase= " +
                    response.ReasonPhrase + "." +
                    "\n\nResponse content = " + response.Content);
            }
            else
            {
                TeamDynamix.Api.Users.User user = JsonSerializer.Deserialize<TeamDynamix.Api.Users.User>(stringData);

                _myLogger.Message("GETUSER TEST SUCCEEDED:\n\n" +
                    "Current User: " + user.FullName);
            }
        }


        public void LoginSSO()
        {
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            HttpResponseMessage response = _httpClient.GetAsync(_website + "/api/auth/loginsso").Result;
            string stringData = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine("Content: " + stringData);
        }


    }
}

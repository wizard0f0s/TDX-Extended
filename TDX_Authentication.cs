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

namespace TDX_WebAPI_Test
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


    public class TDX_Authentication
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

        public TDX_Authentication(string site, string user, string pass)
            : this(site)
        {
            _tdxLogin = new TDX_Login(user, pass);
        }

        public TDX_Authentication(string site, string beid, string webServicesKey, bool isAdmin)
            : this(site)
        {
            _tdx_isAdmin = isAdmin;
            _tdxAdmin = new TDX_Admin(beid, webServicesKey);
        }

        public async Task<string> LoginAsync(HttpClient httpClient)
        {
            var success = false;

            while (!success)
            {
                await _loginAsyncRateLimit.CheckRateLimit();

                var data = JsonSerializer.Serialize(_tdxLogin);
                var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage result = await httpClient.PostAsync("api/auth/login", content);
                _token = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    Console.WriteLine("TDX_Authentication:LoginAsync Error: StatusCode= " + result.StatusCode + ", ReasonPhrase= " + result.ReasonPhrase + ".");
                    Console.WriteLine("Response content = " + _token);
                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Content: " + result.Content);
                    Console.WriteLine("Result.toString(): " + result.ToString());
                    Console.WriteLine("JWT: " + _token);
                    Console.WriteLine();

                    return _token;
                }
            }
            return "";
        }

        public async Task<string> LoginAdminAsync(HttpClient httpClient)
        {
            await _loginAdminAsyncRateLimit.CheckRateLimit();

            var data = JsonSerializer.Serialize(_tdxAdmin);
            var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage result = await httpClient.PostAsync("api/auth/loginadmin", content);
            _token = result.Content.ReadAsStringAsync().Result;

            if (!result.IsSuccessStatusCode)
            {
                Console.WriteLine("TDX_Authentication:LoginAdminAsync Error: StatusCode= " + result.StatusCode + ", ReasonPhrase= " + result.ReasonPhrase + ".");
                Console.WriteLine("Response content = " + _token);

                _token = await LoginAdminAsync(httpClient);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Content: " + result.Content);
                Console.WriteLine("Result.toString(): " + result.ToString());
                Console.WriteLine("JWT: " + _token);
                Console.WriteLine();

            }
            return _token;
        }

        public async Task getUserAsync(HttpClient httpClient)
        {
            await _getUserAsyncRateLimit.CheckRateLimit();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            HttpResponseMessage response = await httpClient.GetAsync("api/auth/getuser");
            string stringData = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("TDX_Authentication:getUserAsync Error: StatusCode= " + response.StatusCode + ", ReasonPhrase= " + response.ReasonPhrase + ".");
                Console.WriteLine("Response content = " + stringData);

                await getUserAsync(httpClient);
            }
            else
            {
                Console.WriteLine("Content: " + stringData);
                TeamDynamix.Api.Users.User user = JsonSerializer.Deserialize<TeamDynamix.Api.Users.User>(stringData);
                Console.WriteLine("Current User is: " + user.FullName);
            }
        }

        public void LoginSSO()
        {
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            _httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            HttpResponseMessage response = _httpClient.GetAsync("api/auth/loginsso").Result;
            string stringData = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine("Content: " + stringData);
        }


    }
}

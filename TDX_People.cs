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
    internal class TDX_People
    {

        private TDX_APIRateLimit _getUserListRateLimit;
        private int _getUserListMaxCalls;
        private int _getUserListTimePeriod; //seconds
        private TDX_APIRateLimit _bulkManageGroupsRateLimit;
        private int _bulkManageGroupsMaxCalls;
        private int _bulkManageGroupsTimePeriod; //seconds

        public TDX_People()
        {
            _getUserListMaxCalls = 1;
            _getUserListTimePeriod = 60;
            _getUserListRateLimit = new TDX_APIRateLimit(_getUserListMaxCalls, _getUserListTimePeriod);
            _bulkManageGroupsMaxCalls = 1;
            _bulkManageGroupsTimePeriod = 120;
            _bulkManageGroupsRateLimit = new TDX_APIRateLimit(_bulkManageGroupsMaxCalls, _bulkManageGroupsTimePeriod);
        }

        public async Task<TeamDynamix.Api.Users.UserListing[]> GetUserListAsync(HttpClient httpClient, TDX_People_GetUserListQuery userListQuery)
        {
            await _getUserListRateLimit.CheckRateLimit();

            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);

            var query = "api/people/userlist?" + userListQuery.getQueryString();

            Console.WriteLine("Query run at: " + DateTime.Now);
            Console.WriteLine();

            HttpResponseMessage response = await httpClient.GetAsync(query);
            string stringData = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("TDX_People:GetUserListAsync Error: StatusCode= " + response.StatusCode + ", ReasonPhrase= " + response.ReasonPhrase + ".");
                Console.WriteLine("Response content = " + stringData);

                return await GetUserListAsync(httpClient, userListQuery);
            }
            TeamDynamix.Api.Users.UserListing[] userListing = JsonSerializer.Deserialize<TeamDynamix.Api.Users.UserListing[]>(stringData);

            if (userListing == null)
                throw new Exception("List of People is NULL");

            return userListing;
        }

        public async Task BulkManageGroupsAsync(HttpClient httpClient, TeamDynamix.Api.Users.UserGroupsBulkManagementParameters bulkManageGroupsParams)
        {
            await _bulkManageGroupsRateLimit.CheckRateLimit();

            var data = JsonSerializer.Serialize(bulkManageGroupsParams);
            var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync("api/people/bulk/managegroups", content);

            string stringData = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("TDX_People:BulkManageGroupAsync Error: StatusCode= " + response.StatusCode + ", ReasonPhrase= " + response.ReasonPhrase + ".");
                Console.WriteLine("Response content = " + stringData);

                await BulkManageGroupsAsync(httpClient, bulkManageGroupsParams);
            }

            Console.WriteLine();
        }
    }

}

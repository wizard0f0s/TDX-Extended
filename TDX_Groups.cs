using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace TDX_Extended
{
    internal class TDX_Groups
    {

        private TDX_APIRateLimit _groupSearchAsyncRateLimit;
        private int _groupSearchAsyncMaxCalls;
        private int _groupSearchAsyncTimePeriod; //seconds

        public TDX_Groups()
        {
            _groupSearchAsyncMaxCalls = 60;
            _groupSearchAsyncTimePeriod = 60;
            _groupSearchAsyncRateLimit = new TDX_APIRateLimit(_groupSearchAsyncMaxCalls, _groupSearchAsyncTimePeriod);
        }

        public async Task<TeamDynamix.Api.Users.Group[]> GroupSearchAsync(HttpClient httpClient, TeamDynamix.Api.Users.GroupSearch searchParams)
        {
            await _groupSearchAsyncRateLimit.CheckRateLimit();

            var data = JsonSerializer.Serialize(searchParams);
            var content = new StringContent(data.ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync("api/groups/search", content);

            string stringData = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("TDX_Groups:GroupSearchAsync Error: StatusCode= " + response.StatusCode + ", ReasonPhrase= " + response.ReasonPhrase + ".");
                Console.WriteLine("Response content = " + stringData);

                return await GroupSearchAsync(httpClient, searchParams);
            }

            Console.WriteLine();
            TeamDynamix.Api.Users.Group[] groupListing = JsonSerializer.Deserialize<TeamDynamix.Api.Users.Group[]>(stringData);

            if (groupListing == null)
                throw new Exception("List of People is NULL");

            return groupListing;
        }
    }
}

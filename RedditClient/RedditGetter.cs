using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RedditClient.entities;

namespace RedditClient
{
    class RedditGetter
    {
        public async Task<string> GetEndpoint(string endpoint)
        {
            var token = Config.Token;
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            //Reddit requires a user agent
            httpClient.DefaultRequestHeaders.Add("User-Agent", "mattbot99");
            var response = await httpClient.GetAsync(endpoint);

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }

        public async Task<Subreddit> GetSubreddit(string subreddit)
        {
            var endpoint = GetEndpoint("https://reddit.com/r/" + subreddit +".json");
            var parseJson = JsonConvert.DeserializeObject<SubredditListing>(await endpoint);
            return parseJson.Data;
        }
    }
}

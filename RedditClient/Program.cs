using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            //var endpoint = "https://oauth.reddit.com/api/v1/me";
            var subreddit = Console.ReadLine();
            Console.Write(await new RedditGetter().GetSubreddit(subreddit));
            Console.Read();
        }
    }
}

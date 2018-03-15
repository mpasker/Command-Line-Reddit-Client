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
            var subreddit = Console.ReadLine();
            var subredditObject = await new RedditGetter().GetSubreddit(subreddit);
            Console.Write(subredditObject);

            var input = Console.ReadLine();
            int postIndex = Convert.ToInt32(input);
            var post = subredditObject.Children[postIndex - 1];
            Console.WriteLine(post);
            KeepTerminalOpen();

        }

        static void KeepTerminalOpen()
        {
            Console.Read();
        }
    }
}

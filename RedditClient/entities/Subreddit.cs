using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditClient.entities;

namespace RedditClient
{
    class Subreddit
    {
        public PostHolder[] Children;

        public override string ToString()
        {
            return String.Join("\n", (object[])Children);
        }
    }
}

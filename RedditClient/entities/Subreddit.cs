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
            var childStrings = "Posts\n";
            for(var i = 1; i < Children.Length; i++)
            {
                childStrings += i;
                childStrings += " ";
                childStrings += Children[i - 1];
                childStrings += "\n";
            }

            return childStrings;
        }
    }
}

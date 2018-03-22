using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient.entities
{
    class Replies
    {
        public Holder<Comment>[] Children;

        public override string ToString()
        {
            return String.Join("\n", (object[])Children);
        }
    }
}

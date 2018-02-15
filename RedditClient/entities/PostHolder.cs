using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient.entities
{
    class PostHolder
    {
        public Post Data;

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

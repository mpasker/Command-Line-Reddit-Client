using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient.entities
{
    class CommentHolder
    {
        public Comment Data;

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

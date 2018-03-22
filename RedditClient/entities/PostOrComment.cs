using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient.entities
{
    class PostOrComment
    {
        public string Body;
        public string Author;
        public int Score;
        public Replies Replies;
        public string Selftext;
    }
}

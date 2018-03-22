using System.Runtime.InteropServices;

namespace RedditClient
{
    internal class PostFromSubreddit
    {
        public string Title;
        public int Score;

        public override string ToString()
        {
            return $"{Title} Score: {Score}";
        }
    }
}
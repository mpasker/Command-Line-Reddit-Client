using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient.entities
{
    public class Holder<T>
    {
        public T Data;
    
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

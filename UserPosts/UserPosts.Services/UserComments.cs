using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPosts.Services
{
    public class UserComments
    {
        public string Name { get; set; }
        public IDictionary<int, string> Comments { get; set; } 

        public UserComments()
        {
            Comments = new Dictionary<int, string>();
        }
    }
}

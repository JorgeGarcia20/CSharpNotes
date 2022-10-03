using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsHttpRequest
{
    /*
     * If you are consulting an API, is important to name the properties exacly as in the JSON object
     */
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nUserId: {UserId}\nTitle: {Title}\nBody: {Body}";
        }
    }
}

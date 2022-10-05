using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MinimalBookData
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }

        public MinimalBookData(string Title, string Author, int Copies)
        {
            this.Title = Title;
            this.Author = Author;
            this.Copies = Copies;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> books = new List<Book>();

        public Library(string Name)
        {
            this.Name = Name;
        }
    }
}

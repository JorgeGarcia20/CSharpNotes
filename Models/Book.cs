using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set;  }
        public double Price { get; set; }
        public int Copies { get; set; }

        public Book(string ISBN, string Title, string Author, string Editorial, double Price, int Copies)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Editorial = Editorial;
            this.Price = Price;
            this.Copies = Copies;
        }
    }
}

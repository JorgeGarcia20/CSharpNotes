using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LibraryData
    {
        public string Name { get; set; }
        public List<MinimalBookData> minimalBooksData = new List<MinimalBookData>();

        public LibraryData(string Name)
        {
            this.Name = Name;
        }
    }
}

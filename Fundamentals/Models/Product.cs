using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    public  class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public Product(string Id, string Name, string Brand)
        {
            this.Id = Id;
            this.Name = Name;
            this.Brand = Brand;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nBrand: {Brand}\n";
        }
    }
}

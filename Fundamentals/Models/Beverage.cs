using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    public class Beverage : Product
    {
        public int Size{ get; set; }
        public string Type { get; set; }

        public Beverage(string Id, string Name, string Brand, int Size, string Type) : base(Id, Name, Brand)
        {
            this.Size = Size;
            this.Type = Type;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nBrand: {Brand}\nSize: {Size}ml\nType: {Type}\n";
        }
    }
}

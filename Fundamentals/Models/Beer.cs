using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Beer(string name, string brand, decimal alcoholPercentage, decimal price, int quantity)
        {
            Name = name;
            Brand = brand;
            AlcoholPercentage = alcoholPercentage;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"BEER DATA\nName: {Name}\nBrand: {Brand}\nAlcohol percentage: {AlcoholPercentage}%\nPrice: {Price}$\nQuantity: {Quantity}\n";
        }
    }
}

using Fundamentals.Models;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fundamentals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // **Creating a list of products and looping it**
            /*Product sabritas = new("00001", "Sabritas Habanero", "Sabritas");
              Beverage Cocacola = new("00002", "Cocacola", "Cocacola Company", 600, "Soda");

              List<Product> productList = new List<Product>();

              productList.Add(sabritas);
              productList.Add(Cocacola);

              foreach(var product in productList)
              {
                  Console.WriteLine(product.ToString());
              }*/

            // ***Connecting to a SQL Server DB***
            // ConnectionDB db = new();
            // Adding a new beer into the table beers
            // Beer IndioBeer = new("Indio", "Grupo Indio", 4.5m, 21.90m, 50);
            // Console.WriteLine(db.Add(IndioBeer));
           
            // ***Removing a beer from the table beers***
            //Console.WriteLine(db.Remove(9));

            // ***Updating a beer from the table beers with id = 8
            // IndioBeer.Quantity = 70;
            // Console.WriteLine(db.Update(IndioBeer, 8));

            // Listing all the existing beers in the table beers and executing his ToString() method.
            /*
            List<Beer> beerList = db.Get();
            foreach (var item in beerList)
            {
                Console.WriteLine(item.ToString());
            }
            */

            // ***Serializacion y deserializacion de JSON*** 
            //Beer myBeer = new("Corona", "Corona", 4.5m, 20.00m, 20);
            //string beerJSON = JsonSerializer.Serialize(myBeer);

            // ***Saving the json in a file text called beerjson.txt***
            //File.WriteAllText("beerjson.txt", beerJSON);

            // ***JSON desealizacion
            //string dataBeer = File.ReadAllText("beerjson.txt");
            //Beer? beer = JsonSerializer.Deserialize<Beer>(dataBeer);
            //Console.WriteLine(beer?.ToString());
        }
    }
}

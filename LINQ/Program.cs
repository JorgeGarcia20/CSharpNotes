using Models;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*var numbers = new List<int>() { 2, 5, 6, 2, 23, 75, 21, 34, 0, 1 };
            int number5 = numbers.Where(d => d == 5).FirstOrDefault();
            var sortedNumbers = numbers.OrderBy(d => d);
            Console.WriteLine(number5);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            var numbersSum = numbers.Sum(d => d);
            Console.WriteLine($"Sum: {numbersSum}");

            var numbersMedia = numbers.Average(d => d);
            Console.WriteLine($"Average: {numbersMedia}");*/

            /*List<Beer> beerList = new List<Beer>()
            {
                new("Modelo Clasica", "Modelo", 4.0m, 20.90m, 50),
                new("Modelo Negra", "Modelo", 4.5m, 25.90m, 60),
                new("Modelo Ambar", "Modelo", 4.3m, 24.90m, 10),
                new("Modelo Pura Malta", "Modelo", 4.5m, 20.90m, 20),
                new("Corona", "Victoria", 4.3m, 19.90m, 100),
                new("Victoria Especial", "Victoria", 4.5m, 18.90m, 100),
            };

            var sortedBeers = from b in beerList
                              where b.Price > 20.0m
                              orderby b.Brand
                              select b;

            foreach (var beer in sortedBeers)
            {
                Console.WriteLine(beer.Name);
            }*/

            /*linq para crear objetos complejos*/

            List<Library> libraries = new List<Library>()
            {
                new Library("Libreria Gandhi")
                {
                    books = new List<Book>()
                    {
                        new Book("978-84-450-0232-4", "El Señor de los Anillos las Dos Torres", "J.R.R. Tolkien", "Minotauro", 225.00, 4),
                        new Book("978-988-2896-66-0", "El Gallo de Oro", "Juan Rulfo", "Editorial RM", 125.00, 10),
                        
                        new Book("978-854-545-015-8", "Cien años de soledad", "Gabriel Garcia Marquez", "Diana", 142.00, 20),
                        new Book("978-968-5208-55-0", "Pedro Paramo", "Juan Rulfo", "Editorial RM", 145.00, 5),
                    }
                },

                new Library("Busca libre")
                {
                    books = new List<Book>()
                    {
                        new Book("978-84-450-0232-2", "El Hobbit", "J.R.R. Tolkien", "Minotauro", 258.00, 3),
                        new Book("978-84-450-0232-3", "El Señor de los Anillos La Comunidad del Anillo", "J.R.R. Tolkien", "Minotauro", 192.00, 4),
                        new Book("978-988-2896-66-0", "El llano en llamas", "Juan Rulfo", "Editorial RM", 105.00, 10),
                        new Book("978-964-645-715-3", "Cronica de una muerte anunciada", "Gabriel Garcia Marquez", "Diana", 102.00, 7),
                        new Book("978-234-595-045-5", "El General no tiene quien le escriba", "Gabriel Garcia Marquez", "Diana", 192.00, 8),
                    }
                },

                new Library("La Gaviota")
                {
                    books = new List<Book>()
                    {
                        new Book("978-964-645-715-3", "Cronica de una muerte anunciada", "Gabriel Garcia Marquez", "Diana", 102.00, 9),
                        new Book("978-84-450-0232-5", "El Señor de los Anillos El Retorno del Rey", "J.R.R. Tolkien", "Minotauro", 245.00, 7),
                    }
                },

                new Library("La Pirata")
            };

            var library = (from l in libraries
                           where l.books.Where(b => b.Author == "Juan Rulfo").Count() > 0
                           select new LibraryData(l.Name)
                           {
                               minimalBooksData = (from c in l.books
                                                   select new MinimalBookData(c.Title, c.Author, c.Copies)).ToList()
                           }).ToList();
        }
    }
}

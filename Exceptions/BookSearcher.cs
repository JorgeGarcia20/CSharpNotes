using System;
using System.Collections.Generic;
using Models;
using System.Linq;


namespace Exceptions
{
    public class BookSearcher
    {
        List<Book> books = new List<Book>()
        {
            new Book("978-84-450-0232-4", "El Señor de los Anillos las Dos Torres", "J.R.R. Tolkien", "Minotauro", 225.00, 4),
            new Book("978-988-2896-66-0", "El Gallo de Oro", "Juan Rulfo", "Editorial RM", 125.00, 10),           
            new Book("978-854-545-015-8", "Cien años de soledad", "Gabriel Garcia Marquez", "Diana", 142.00, 20),
            new Book("978-968-5208-55-0", "Pedro Paramo", "Juan Rulfo", "Editorial RM", 145.00, 5),
            new Book("978-84-450-0232-2", "El Hobbit", "J.R.R. Tolkien", "Minotauro", 258.00, 3),
            new Book("978-84-450-0232-3", "El Señor de los Anillos La Comunidad del Anillo", "J.R.R. Tolkien", "Minotauro", 192.00, 4),
            new Book("978-988-2896-66-0", "El llano en llamas", "Juan Rulfo", "Editorial RM", 105.00, 10),
            new Book("978-964-645-715-3", "Cronica de una muerte anunciada", "Gabriel Garcia Marquez", "Diana", 102.00, 7),
            new Book("978-234-595-045-5", "El General no tiene quien le escriba", "Gabriel Garcia Marquez", "Diana", 192.00, 8),
        };

        public int GetCopies(string name){
            Book? book = (from b in books
                        where b.Title == name
                        select b).FirstOrDefault();

            if(book == null){
                throw new BookNotFoundException("The book you are looking for is no more availabre :(");
            }
        
            return book.Copies;
        }

    }
}
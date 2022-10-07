using System;

namespace Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bookSearcher = new BookSearcher();
            try
            {
                // Here we araise an exception of type BookNotFoundException
                int copies = bookSearcher.GetCopies("1984");

                Console.WriteLine(copies);
            }
            catch (BookNotFoundException ex)
            {
                // And here we catch it and show his message.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // This part of the code allways goin to be executed.
                Console.WriteLine("This sections allways going to be executed.");
            }
        } 
    }
}

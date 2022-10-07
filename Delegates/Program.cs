using System;
using Models;
using System.Collections.Generic;

namespace Delegates
{
    public static class Program
    {
        /*
        Delegates
        Un delegado es un tipo que encapsula de forma segura un método.
        Normalmente un objeto delegado se construye al proporcionar el nombre
        del método que el delegado encapsula o con una expresion lambda.
        Una vez que se crea una instancia de delegado, el delegado pasará al método
        una llamada de método realizada al delegado. 
        */

        /*
        The Func delegate takes zero, one or more input parameters and returns a value
        with its out parameter.
        */

        public delegate void Del(string message);

        public static void Main(string[] args)
        {
            // Del handler = DelegateMethod;
            // handler("Hello world from a delegate!");
            // MethodWithCallback(100, 299, handler);
            
            // FUNC DELEGATE

            // The first two ints are the parameters and the last int represents the return value.
            // Func<int, int, int> Addition = AddNumbers;
            // int result = Addition(10, 20);
            // Console.WriteLine(result);

            // Func with lambda expression:
            Func<int, int, int> AdditionFunc = (num1, num2) => num1 + num2;
            int resultFunc = AdditionFunc(30, 40);
            // Console.WriteLine($"The result using the Func delegate is:: {resultFunc}");

            // ACTION DELEGATE
            /*
            The Action delegate doesn't return a value, an Action delegate can be used with a method that has a void return type
            */
            
            Action<int, int> Subtraction = OperationResult;

            Action<int, int> AdditionAction = (num1, num2) => Console.WriteLine(num1 + num2);
            
            // Subtraction(40, 10);
            // AdditionAction(30, 80);

            //PREDICADES
            /*
            List<int> numbers = new List<int>(){2, 4, 6, 8, 19, 21, 23, 67, 22, 62, 90, 12, 23};
            
            Predicate<int> areMultipleOfTwo = x => x % 2 == 0;
            Predicate<int> areNotMultipleOfTwo = x => !areMultipleOfTwo(x);
            
            List<int> numbersMultipleOfTwo = numbers.FindAll(areMultipleOfTwo);
            List<int> numbersAreNotMultipleOfTwo = numbers.FindAll(areNotMultipleOfTwo);

            Console.WriteLine("\nMultiples of two");
            numbersMultipleOfTwo.ForEach(x => {Console.WriteLine(x);});

            Console.WriteLine("\nNo multiples of two");
            numbersAreNotMultipleOfTwo.ForEach(x => {Console.WriteLine(x);});
            */
            List<Book> books = new List<Book>(){
                new Book("978-84-450-0232-2", "El Hobbit", "J.R.R. Tolkien", "Minotauro", 258.00, 3),
                new Book("978-84-450-0232-3", "El Señor de los Anillos La Comunidad del Anillo", "J.R.R. Tolkien", "Minotauro", 192.00, 4),
                new Book("978-988-2896-66-0", "El llano en llamas", "Juan Rulfo", "Editorial RM", 105.00, 10),
                new Book("978-964-645-715-3", "Cronica de una muerte anunciada", "Gabriel Garcia Marquez", "Diana", 102.00, 7),
                new Book("978-234-595-045-5", "El General no tiene quien le escriba", "Gabriel Garcia Marquez", "Diana", 192.00, 8),
                new Book("978-964-645-715-3", "Cronica de una muerte anunciada", "Gabriel Garcia Marquez", "Diana", 102.00, 9),
                new Book("978-84-450-0232-5", "El Señor de los Anillos El Retorno del Rey", "J.R.R. Tolkien", "Minotauro", 245.00, 7),
                new Book("978-84-450-0232-4", "El Señor de los Anillos las Dos Torres", "J.R.R. Tolkien", "Minotauro", 225.00, 4),
                new Book("978-988-2896-66-0", "El Gallo de Oro", "Juan Rulfo", "Editorial RM", 125.00, 10),
                new Book("978-854-545-015-8", "Cien años de soledad", "Gabriel Garcia Marquez", "Diana", 242.00, 20),
                new Book("978-968-5208-55-0", "Pedro Paramo", "Juan Rulfo", "Editorial RM", 145.00, 5),
            };

            // This function show the book that his price is greater than 200.00 using a predicate as condition. 
            books.GetExpensiveBooks( b => b.Price >= 200.00);

        }

        // this agrega una extencion al tipo de dato List<book> para que esto funcione la clase debe ser static.
        public static void GetExpensiveBooks( this List<Book> books, Predicate<Book> condition)
        {
            List<Book> expensiveBooks = books.FindAll(condition);
            expensiveBooks.ForEach(b => {Console.WriteLine(b.Title);});
        }

        public static void OperationResult(int num1, int num2)
        {
            Console.WriteLine($"The result is {num1 - num2}");
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        // this method is going to be to the delegate
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback($"The number is: {param1 + param2}");
        }
    }
}
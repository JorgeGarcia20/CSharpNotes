namespace Delegates
{
    public class Program
    {
        /*
        Delegates
        Un delegado es un tipo que encapsula de forma segura un método.
        Normalmente un objeto delegado se construye al proporcionar el nombre
        del método que el delegado encapsula o con una expresion lambda.
        Una vez que se crea una instancia de delegado, el delegado pasará al método
        una llamada de método realizada al delegado. 
        */

        public delegate void Del(string message);

        public static void Main(string[] args)
        {
            Del handler = DelegateMethod;
            handler("Hello world from a delegate!");
            MethodWithCallback(100, 299, handler);
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
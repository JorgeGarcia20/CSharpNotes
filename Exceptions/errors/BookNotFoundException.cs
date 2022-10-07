using System;

namespace Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(): base(){ }
        public BookNotFoundException(string message): base(message){ }
        public BookNotFoundException(string message, Exception inner): base(message, inner){ }
    }
}
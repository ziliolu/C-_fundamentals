using System;
using System.Reflection;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("title 1", 5),
                new Book("title 2", 7),
                new Book("title 3", 17)
            };
        }
    }
}

using System;
using System.Reflection;

namespace Linq
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("Btitle 1", 9),
                new Book("Atitle 2", 9),
                new Book("Ctitle 3", 17)
            };
        }
    }
}

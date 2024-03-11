using System;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators ----> cleaner and simpliest 
            var cheaperBooks = from b in books
                                    where b.Price < 10
                                    orderby b.Title
                                    select b.Title;

            // LINQ Extensions Methods ----> more powerful
            var cheapBooks = books
                                .Where(books => books.Price < 10)
                                .OrderBy(book => book.Title)
                                .Select(book => book.Title);

            foreach(var book in cheapBooks)
                System.Console.WriteLine(book);

            var bookSingle = books.Single(b => b.Title == "Atitle 2");
            var bookFirst = books.First(b => b.Price == 9);
            var lastBooks = books.Skip(1).Take(2);
            var count = books.Count();
            var maxPrice = books.Single(book => book.Price == books.Max(b => b.Price));
            var totalPrices = books.Sum(b => b.Price);

            System.Console.WriteLine(bookSingle.Price);
            System.Console.WriteLine(bookFirst.Title);
            System.Console.WriteLine("Total of books: " + count);
            System.Console.WriteLine("Most expensive one: " + maxPrice.Title);
            System.Console.WriteLine("Total sum of prices: " + totalPrices);
            foreach(var b in lastBooks)
                System.Console.WriteLine("Last book: " + b.Title);
        }
    }
}

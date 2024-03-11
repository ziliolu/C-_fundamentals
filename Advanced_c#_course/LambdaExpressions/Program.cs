using System;
using System.Globalization;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string []args)
        {
            // args => expression

            //no args 
            // () => ...
            //1 arg
            // x => ...
            //multiple args
            // (x, y, z) => ...

            const int factor = 5;

            Func<int, int> multiplier = n => n*factor;
            var result = multiplier(10);

            System.Console.WriteLine(result);
            
            Func<int, int> square = number => number*number;
            System.Console.WriteLine(square(5));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach(var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }
        }

        //Func<int, int> = first: argument, second: return value
        // number => number * number;      
        
        /* static int Square(int number)
        {
            return number * number;
        } */
    }
}

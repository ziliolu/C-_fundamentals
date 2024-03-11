using System;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string []args)
        {
            try
            {
                var calculator = new Calculator();
                System.Console.WriteLine(calculator.Division(5, 1));
            }
            catch(Exception)
            { 
                System.Console.WriteLine("Sorry, error found");
            }
        }
    }
}

using System;

namespace Delegates
{
    
    public delegate void MyDelegate(int x, int y);

    public class Program
    {
        static void Main(string [] args)
        {
            MyDelegate myDelegate = AddNumbers;

            myDelegate(1, 4);

            myDelegate = MultiplyNumbers;

            myDelegate(3, 9);
        }
        static void AddNumbers(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }

        // Method to multiply two numbers
        static void MultiplyNumbers(int x, int y)
        {
            Console.WriteLine($"Product: {x * y}");
        }
    }

}

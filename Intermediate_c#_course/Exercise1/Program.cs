using System;

namespace Exercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Stack's initialization");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            stack.Push(3);
            try
            {
                stack.Push(null);
            }
            catch(InvalidOperationException)
            {
                System.Console.WriteLine("Invalid operation caught: null is not acceptable");
            }

            stack.Print();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            try
            {
                stack.Pop();
            }
            catch(InvalidOperationException)
            {
                System.Console.WriteLine("Invalid operation caught: list is empty");
            }

            stack.Print();
            stack.Clear();

            stack.Print();

            System.Console.WriteLine("=== Document Test ===");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
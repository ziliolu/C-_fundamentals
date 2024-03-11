using System;

namespace NullableTypes
{
    public class Program
    {
        static void Main(string []args)
        {
            DateTime? date = null;
            string? name = null;

            System.Console.WriteLine(name);

            System.Console.WriteLine(date.GetValueOrDefault());
            System.Console.WriteLine(date.HasValue);
            System.Console.WriteLine(date.Value);
        }
    }
}

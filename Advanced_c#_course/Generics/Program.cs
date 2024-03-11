using System;
using Microsoft.VisualBasic;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new GenericDictionary<string, int>();
            dictionary.Add("Luiza", 21);
        }
    }
}

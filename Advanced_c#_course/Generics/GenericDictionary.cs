using System;

namespace Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            System.Console.WriteLine("Adding to the generic list");
        }
    }
}

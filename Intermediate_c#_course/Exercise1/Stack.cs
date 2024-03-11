using System;

namespace Exercise1
{
    public class Stack
    {
        public List<object> stack = new List<object>();

        public Stack(){}
        public void Push(object obj)
        {
            System.Console.WriteLine("Push method called");
            if(obj == null)
                throw new InvalidOperationException();
            stack.Add(obj);
        }
        public object Pop()
        {
            System.Console.WriteLine("Pop method called");
            if(!stack.Any())
                throw new InvalidOperationException();
            object obj = stack[0];
            stack.RemoveAt(0);
            return obj;
        }
        public void Clear()
        {
            System.Console.WriteLine("Clear method called");
            stack.Clear();
        }

        public void Print()
        {
            System.Console.WriteLine("Print method called");
            foreach(var element in stack)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}

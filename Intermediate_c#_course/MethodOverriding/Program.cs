using System;

namespace MethodOverriding
{
    public class Program
    {
        public static void Main(string []args)
        {
            Shape rectangle = new Rectangle();
            Shape circle = new Circle();
            rectangle.Draw();
            circle.Draw();
        }
    }
}

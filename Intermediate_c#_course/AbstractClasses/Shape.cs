using System;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Rectangle");
        }
    }

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
        public void Select()
        {
            System.Console.WriteLine("Selecting the shape");
        }
    }
}

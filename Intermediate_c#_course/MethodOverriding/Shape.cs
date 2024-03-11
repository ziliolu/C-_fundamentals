using System;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Circle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Rectangle");
            base.Draw();
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Default draw");
        }
    }
}

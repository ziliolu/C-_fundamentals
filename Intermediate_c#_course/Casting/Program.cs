using System;
using System.Collections;

namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Upcasting

            // Text and shape are both 
            // pointing to the same place in memory.
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100; 

            System.Console.WriteLine(text.Width);

            var list = new ArrayList();
            list.Add(1);
            list.Add("name");
            list.Add(new Text());

            var anotherList = new List<int>();
            var shapeList = new List<Shape>();

            //Downcasting
            
            // we get a limited view and we're not able to see the text' attributes
            Shape shape1 = new Text();
            
            // so we need to downcast shape to have access to text' attributes
            Text text1 = (Text) shape1;
        

        }
    }
}

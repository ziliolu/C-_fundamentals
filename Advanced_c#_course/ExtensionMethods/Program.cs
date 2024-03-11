using System;

/* Methods

    allow us to add methods to an existing class without 
    - changing its source code or
    - creating a new class that inherits from it

    Extensions could be in the System namespace to make it easier :) 

    - use the extensions methods just if you really need it
    - use the extensions methods that are already created

*/

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string []args)
        {
            string Post = "This is supposed to be a very long blogpost bla bla bla bla...";
            var shortenedPost = Post.Shorten(6);
            System.Console.WriteLine(shortenedPost);
        }
    }

}

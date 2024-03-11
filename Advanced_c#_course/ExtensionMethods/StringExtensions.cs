
/* 
    Methods Extensions 

    allow us to add methods to an existing class without 
    - changing its source code or
    - creating a new class that inherits from it
*/

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to zero.");
            if(numberOfWords == 0)
                return "";
            
            var words = str.Split(' ');
                return str;

            if(words.Length <= numberOfWords)

            return string.Join(" ", words.Take(numberOfWords)); 
        }
    }
}

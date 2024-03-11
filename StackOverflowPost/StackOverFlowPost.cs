
using System.ComponentModel;

namespace StackOverflow
{
   
    public class StackOverflowPost
    {
        static void Main(string[] args)
        {
            Post post = new Post("Sunset", "Great sunset in the evening");
            post.VoteDown();
            post.VoteUp();
            post.VoteDown();
            System.Console.WriteLine(post.GetDownVotes());
            System.Console.WriteLine(post.GetUpVotes());
        }
    } 

}

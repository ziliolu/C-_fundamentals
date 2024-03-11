using System;

namespace StackOverflow
{
    public class Post
    {
        // Atributtes 
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _dateTimeCreation { get; set; }
        private int _upVotes { get; set; }
        private int _downVotes { get; set; }

        //Constructors & Methods
        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
        }

        public void VoteUp()
        {
            this._upVotes++;
        }

        public void VoteDown()
        {
            this._downVotes++;
        }

        public int GetUpVotes()
        {
            return this._upVotes;
        }

        public int GetDownVotes()
        {
            return this._downVotes;
        }

    }

}


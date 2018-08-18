using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.Classes_Exercise
{
    public class Post
    {
        public String Title { get; private set; }
        public String Description { get; private set; }
        public DateTime CreationTime { get; private set; }
        public int Votes { get; private set; }

        public Post(string title,string description)
        {
            Title = title;
            Description = description;
            CreationTime = DateTime.Now;
        }

        public void UpVote()
        {
            Votes += 1;
        }

        public void DownVote()
        {
            Votes -= 1;
        }

    }
}

using System.Collections.Generic;

namespace MessageBoard.Models
{
    public class Group
    {
        public int GroupId {get; set; }
        public string Title {get; set; }
        public ICollection<Post> Posts {get;}
        public Group()
        {
            this.Posts = new HashSet<Post>();
        }
    }
}
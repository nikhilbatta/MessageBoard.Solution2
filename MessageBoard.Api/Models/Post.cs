using MessageBoard.Entities;
namespace MessageBoard.Models
{
    public class Post
    {
        public int PostId {get; set; }
        public string Title {get; set; }
        public string Body {get; set; }
        public int GroupId {get; set; }
        public string UserName {get; set; }
        public string DateOfPost {get; set; } 
        public int Id {get;set;}
        public User user {get; set;}  
    }

}
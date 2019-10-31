using MessageBoard.Entities;
using System; 
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
        public int ID {get;set;}
        public User1 user {get; set;}

       
        public static void CreatePost(Post newPost)
        {
            Console.WriteLine("this is a log from the post model" + newPost.PostId);
            Console.WriteLine("this is a log from the post model" + newPost.GroupId);
           var apiCallTask = ApiHelper.ApiPostToSpecificGroup(newPost);
           var result = apiCallTask.Result;
        }
    }
    
}
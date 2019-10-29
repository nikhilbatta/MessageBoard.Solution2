using System.Collections.Generic;
using MessageBoard.Models;

namespace MessageBoard.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public ICollection<Post> Posts {get;set;}
        public User()
        {
            this.Posts = new HashSet<Post> () ;
        }
    }
}
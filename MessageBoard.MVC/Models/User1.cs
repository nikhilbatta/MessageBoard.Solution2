using System.Collections.Generic;
using MessageBoard.Models;
using System;

namespace MessageBoard.Entities
{
    public class User1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public ICollection<Post> Posts {get;set;}
        public User1()
        {
            this.Posts = new HashSet<Post> () ;
        }
        public static void CreateUser(User1 newUser)
        {
           var apiCallTask = ApiHelper.ApiCallGroupIndex();
           var result = apiCallTask.Result;
           Console.WriteLine(result);
        }
    }
}
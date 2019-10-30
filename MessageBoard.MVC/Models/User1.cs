using System.Collections.Generic;
using MessageBoard.Models;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
        public static void CreateUser(User1 newOne)
        {
           var apiCallTask = ApiHelper.ApiCallNewUser(newOne);
           var result = apiCallTask.Result;
           Console.WriteLine(result);
        }
        public static User1 GetUser(User1 loggedin)
        {
            Console.WriteLine(loggedin.Username);
            var apiCallTask = ApiHelper.ApiGetUser(loggedin);
            var result = apiCallTask.Result;
            Console.WriteLine(result);
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Console.WriteLine(jsonResponse);
            User1 groupList = JsonConvert.DeserializeObject<User1>(jsonResponse.ToString());
            return groupList;
        }
    }
}
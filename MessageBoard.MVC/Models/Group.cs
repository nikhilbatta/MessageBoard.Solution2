using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Group
    {
        
        public int GroupId {get; set; }
        [Required]
        public string Title {get; set; }
        public ICollection<Post> Posts {get;}
        public Group()
        {
            this.Posts = new HashSet<Post>();
        }
        public static List<Group> GetAllGroups()
        {
            var apiCallTask = ApiHelper.ApiCallGroupIndex();
            var result = apiCallTask.Result;
            Console.WriteLine(result);
            
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Group> groupList = JsonConvert.DeserializeObject<List<Group>>(jsonResponse.ToString());

            return groupList;
        }
    }
}
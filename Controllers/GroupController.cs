using MessageBoard.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MessageBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private MessageBoardContext _db;

        public GroupController(MessageBoardContext db)
        {
            _db = db;
        }

        // GET api/group
        [HttpGet]
        public ActionResult<IEnumerable<Group>> Get(string startTime, string endTime)
        {
           if(!String.IsNullOrEmpty(startTime) && !String.IsNullOrEmpty(endTime))
           {
               //string queryable

               //search

               //query

               //string

               //object
           }
           
            return _db.Groups.Include(g => g.Posts).ToList();
        }

        // POST api/group
        [HttpPost]
        public void Post([FromBody] Group newGroup)
        {
            _db.Groups.Add(newGroup);
            _db.SaveChanges();
        }

        // // GET api/group/{"groupId"}
        [HttpGet("{groupId}")]
        public ActionResult<IEnumerable<Post>> Get(int groupId)
        {
            return _db.Posts.Where(p => p.GroupId == groupId).ToList();
        }

        // POST api/group/{"groupId"}
        [HttpPost("{groupId}")]
        public void Post([FromBody] Post post, int groupId)
        {
            if (_db.Groups.Any(group => group.GroupId == groupId))
            {
                
                post.GroupId = groupId;
                _db.Posts.Add(post);
                _db.SaveChanges();
            }
        }

        [HttpPut("{id}/{name}")]
        public void Put(int id, string name,[FromBody] Post updatedPost)
        { 
            Post foundPost = _db.Posts.FirstOrDefault(p => p.PostId == id);
            if(foundPost.UserName == name)
            {
                updatedPost.PostId = id;
                _db.Entry(updatedPost).State = EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
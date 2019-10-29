using MessageBoard.Models;
using MessageBoard.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
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
        [HttpGet]
        public ActionResult<IEnumerable<Group>> Get()
        {
            return _db.Groups.Include(p => p.Posts).ToList();
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
        public ActionResult<Group> Get(int groupId)
        {
            return _db.Groups.Include(p => p.Posts).FirstOrDefault(p => p.GroupId == groupId);
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

        
    }
}
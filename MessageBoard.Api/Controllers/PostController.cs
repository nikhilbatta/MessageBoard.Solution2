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
    public class PostController : ControllerBase
    {
        private MessageBoardContext _db;

        public PostController(MessageBoardContext db)
        {
            _db = db;
        }
        //GET api/group/?startString=*&?endString=*
        [HttpGet]
        public ActionResult<IEnumerable<Post>> Get(string startstring, string endstring, string username)
        {
            var query = _db.Posts.AsQueryable();
            if(startstring != null)
            {
                query = query.Where(p => string.Compare(p.DateOfPost, startstring) >= 0);
            }
            if(endstring != null)
            {
                query = query.Where(p => string.Compare(p.DateOfPost, endstring) <= 0);
            }
            if(username!= null)
            {
                query = query.Where(p => p.UserName == username);
            }
            return query.ToList();
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

        [HttpPost("{id}")]
        public void Post([FromBody] Post post)
        {
            Console.WriteLine("this got here");
            Console.WriteLine(post.PostId);
            _db.Posts.Add(post);
            _db.SaveChanges();
        }
    }
}

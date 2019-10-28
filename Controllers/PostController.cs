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
        public ActionResult<IEnumerable<Post>> Get(string startstring, string endstring)
        {
            var query = _db.Posts.AsQueryable();

            Console.WriteLine(startstring);
            Console.WriteLine(endstring);
            query = query.Where(p => string.Compare(p.DateOfPost, startstring) >= 0 && string.Compare(p.DateOfPost, endstring) <= 0);
            return query.ToList();
        }
    }
}

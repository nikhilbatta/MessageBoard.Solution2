using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MessageBoard.Services;
using MessageBoard.Entities;
using MessageBoard.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MessageBoard.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly MessageBoardContext _db;

        public UsersController(IUserService userService, MessageBoardContext db)
        {
            _userService = userService;
            _db = db;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            Console.WriteLine(userParam.Username);
            Console.WriteLine(userParam.Password);
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }


        [AllowAnonymous]
        [HttpPost("create")]
        public void Create([FromBody]User user)
        {
            if(!_db.Users.Any( a => a.Username == user.Username))
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }
    }
}
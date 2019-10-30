using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.MVC.Models;
using MessageBoard.Models;
using MessageBoard.Entities;

namespace MessageBoard.MVC.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            var allGroups = Group.GetAllGroups();
            return View(allGroups);
        }

        public IActionResult Details()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult CreateWay()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateWay(User1 newUser)
        {
            Console.WriteLine(newUser.Username);
            User1.CreateUser(newUser);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User1 authenticate)
        {
            Console.WriteLine("this is from the login method" + authenticate.Username);
            User1 foundUser = User1.GetUser(authenticate);
            return RedirectToAction("Index");
        }
    }
}
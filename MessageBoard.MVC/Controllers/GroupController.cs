using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.MVC.Models;
using MessageBoard.Models;

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
    }
}
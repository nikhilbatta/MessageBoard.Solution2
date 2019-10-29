﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.MVC.Models;
using MessageBoard.Models;

namespace MessageBoard.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allGroups = Group.GetAllGroups();
            return View(allGroups);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data = "Value,Value1,Value2,Value3"; //list of strings that you need to show on the chart. as mentioned in the example from c-sharpcorner
            ViewBag.ObjectName = "Test,Test1,Test2,Test3";
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

// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Authorization;
// using MessageBoard.Services;
// using MessageBoard.Entities;
// using MessageBoard.Models;
// using System.Collections.Generic;
// using System.Linq;
// using System;

// namespace EmployeeManagement.Controllers
// {
//     public class AdministrationController : Controller
//     {
//         private readonly RoleManager<ApplicationUser> roleManager;
//         public AdministrationController(RoleManager<ApplicationUser> roleManager)
//         {
//             this.roleManager = roleManager;
//         }

//         [HttpGet]
//         public IActionResult CreateRole()
//         {
//             return View();
//         }
//     }
    
// }
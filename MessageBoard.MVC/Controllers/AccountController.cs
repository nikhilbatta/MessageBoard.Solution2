// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Identity;
// using MessageBoard.Models;
// using System.Threading.Tasks;
// using MessageBoard.ViewModels;

// namespace SweetSavory.Controllers
// {
//     public class AccountController : Controller
//     {
//         private readonly MessageBoardContext _db;
//         private readonly UserManager<ApplicationUser> _userManager;
//         private readonly SignInManager<ApplicationUser> _signInManager;

//         public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, MessageBoardContext db)
//         {
//              _userManager = userManager;
//             _signInManager = signInManager;
//             _db = db;
//         }
//         public ActionResult Index()
//         {
//             return View();
//         }
//         [HttpGet]
//          public IActionResult Register()
//         {
//             return View();
//         }
//         public async Task<ActionResult> Register (RegisterViewModel model)
//         {
//             var user = new ApplicationUser { UserName = model.Email };
//             IdentityResult result = await _userManager.CreateAsync(user, model.Password);
//             if (result.Succeeded)
//             {
//                 return RedirectToAction("Index");
//             }
//             else
//             {
//                 return View();
//             }
//         }
//         public ActionResult Login()
//         {
//             return View();
//         }
//         [HttpPost]
//         public async Task<ActionResult> Login(LoginViewModel model)
//         {
//             Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
//             if (result.Succeeded)
//             {
//                 return RedirectToAction("Index");
//             }
//             else
//             {
//                 return View();
//             }
//         }
//          [HttpPost]
//         public async Task<ActionResult> LogOff()
//         {
//             await _signInManager.SignOutAsync();
//             return RedirectToAction("Index");
//         }
       

//     }
// }
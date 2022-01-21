using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using UserSignup.Models;
using static DataLibrary.Logic.UserProcessor;

namespace UserSignup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserModel user)
        {   
            if(ModelState.IsValid)
            {
                CreateUser(user.Username, user.Email);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Members()
        {
            var data = ShowUsers();
            List<UserModel> allUsers = new();

            foreach(var user in data)
            {
                allUsers.Add(new UserModel { Username = user.Username } );
            }

            return View(allUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

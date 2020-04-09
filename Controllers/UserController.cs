using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            ViewBag.Username = user.Username;
            ViewBag.Email = user.Email;

            if (string.IsNullOrEmpty(user.Password))
            {
                ViewBag.Error = "Password required.";
                return View(user);
            }

            if(user.Password != verify)
            {
                ViewBag.Error = "Passwords do not match.";
                return View(user);
            }

            ViewBag.Welcome = "Welcome, " + user.Username + "!";

            return Redirect("/User");
        }
    }
}
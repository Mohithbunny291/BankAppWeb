using BankAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BankAppWeb.Controllers
{
    public class HomeController : Controller
    {
        // Display the login page
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (ModelState.IsValid)
            {
                // Simulate login success if username is "admin" and password is "password"
                // In real applications, validate against a database or user store
                if (user.Username == "admin" && user.Password == "password")
                {
                    // Set session or authentication cookie here
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }
            return View(user);
        }

        public IActionResult Logout()
        {
            // Clear session or authentication cookie here
            return RedirectToAction("Login");
        }
    }
}

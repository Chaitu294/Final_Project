using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Final_Project.Controllers
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
            //var userEmail = HttpContext.Session.GetString("UserEmail");
            //if (string.IsNullOrEmpty(userEmail))
            //{
            //    // Session expired, redirect to login
            //    return RedirectToAction("Login", "Account");
            //}
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contact = new ContactModel
            {
                Phone = "555-555-5555",
                Email = "example@hotmail.com",
                GitHubUrl = "https://github.com/Zaikur"
            };

            return View(contact);
        }
    }
}

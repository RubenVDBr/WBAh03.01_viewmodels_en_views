using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        [Route("home/index")]
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("home/about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("home/search/{id:int}")]
        public IActionResult SearchById(int id)
        {
            return Content($"You searched Id: {id}", "text/plain");
        }

        [Route("home/search/{SearchString}")]
        public IActionResult SearchByString(string searchString)
        {
            return Content($"You searched string: {searchString}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

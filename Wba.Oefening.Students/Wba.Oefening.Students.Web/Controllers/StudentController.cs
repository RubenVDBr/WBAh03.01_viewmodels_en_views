using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentController : Controller
    {
        [Route("Students/index")]
        public IActionResult Index()
        {
            ViewData["pageTitle"] = "Studentpage";
            ViewBag.Message = "Welcome to the student index page";

            return View();
        }

        [Route("students/details/{id:int}")]
        public IActionResult Details()
        {
            return View();
        }
    }
}

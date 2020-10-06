using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wba.Oefening.Students.Web.Controllers
{
    [Route("Students/index")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewData["pageTitle"] = "Studentpage";
            ViewBag.Message = "Welcome to the student index page";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H2.ActionResults.Web.Models;
using Microsoft.AspNetCore.Identity.UI.Pages;
using Microsoft.AspNetCore.Mvc;

namespace H2.ActionResults.Web.Controllers
{
    public class ResponseTypesController : Controller
    {
        public IActionResult Fail()
        {
            return NotFound();
        }

        public IActionResult Forward()
        {
            return Redirect("https://www.cyberpunk.net");   
        }

        public IActionResult File()
        {
            return View();
        }
    }
}

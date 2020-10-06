using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.ActionResults.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string content =
                "<ul>" +
                "<li><a href='https://www.cyberpunk.net/'>Cyberpunk</a></li>" +
                "<li><a href='https://www.cyberpunk.net/'></a>More Cyberpunk</li>" +
                "<li><a href='https://localhost:44345/Home/Whatsmyname'>Whatsmyname</a></li>" +
                "</ul>";


            StringBuilder stringBuilder = new StringBuilder();
            string site1 = "https://www.cyberpunk.net/";
            stringBuilder.AppendLine(site1);
            return Content(content, "text/html");
        }

        public IActionResult Whatsmyname()
        {
            string content = $"Welkom {Environment.UserName}," +
                $" datum={DateTime.Now}";

            return Content(content, "text/plain");
        }

    }
}

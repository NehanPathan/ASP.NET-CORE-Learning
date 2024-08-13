using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>(){
                "Paris",
                "New York",
                "New Mumbai",
                "Rome"
            };
            return View();
        }
        [Route("/about")]
        public IActionResult About()
        {


            return View();
        }
    }
}

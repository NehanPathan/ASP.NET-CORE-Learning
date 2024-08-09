using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LayoutViewsExample.Controllers
{
    
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/about-company")]

        public IActionResult About()
        {
            return View();
        }

        [Route("/contact-support")]

        public IActionResult Contact()
        {
            return View();
        }

    }
}
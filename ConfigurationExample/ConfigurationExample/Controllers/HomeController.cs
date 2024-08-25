using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConfigurationExample.Controllers
{
    public class HomeController(IConfiguration configuration) : Controller
    {
        //private field
        private readonly IConfiguration _configuration = configuration;

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.MyKey = _configuration["MyKey"];
            ViewBag.MyAPIKey = _configuration.GetValue("MyAPIKey","the default value");
            return View();
        }
}
}
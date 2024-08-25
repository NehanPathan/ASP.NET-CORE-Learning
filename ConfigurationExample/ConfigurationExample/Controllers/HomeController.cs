using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        //private field
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration){
            _configuration = configuration;
        }


        [Route("/")]
        public IActionResult Index()
        {
            // ViewBag.ClientId = _configuration["weatherapi:ClientId"];
            // ViewBag.ClientSecret = _configuration.GetValue("weatherapi:ClientSecret","the default ClientSecret value");

            IConfiguration weatherapi = _configuration.GetSection("weatherapi");

             ViewBag.ClientId = weatherapi["ClientId"];
            ViewBag.ClientSecret = weatherapi.GetValue("ClientSecret","the default ClientSecret value");

            return View();
        }
}
}
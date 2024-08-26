using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        //private field
        private readonly WeatherApiOptions _options;
        public HomeController(IOptions<WeatherApiOptions> weatherApiOptions){
            _options = weatherApiOptions.Value;
        }


        [Route("/")]
        public IActionResult Index()
        {
            

             ViewBag.ClientId = _options.ClientId;
            ViewBag.ClientSecret = _options.ClientSecret;


            return View();
        }
}
}
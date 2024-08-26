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

            // IConfiguration weatherapi = _configuration.GetSection("weatherapi");

            //  ViewBag.ClientId = weatherapi["ClientId"];
            // ViewBag.ClientSecret = weatherapi.GetValue("ClientSecret","the default ClientSecret value");


            //Get : Loads configuration values into new Options object
            // WeatherApiOptions options = _configuration.GetSection("weatherapi").Get<WeatherApiOptions>();

            //Bind : Loads configuration values into existing Options object
            WeatherApiOptions options = new WeatherApiOptions();
            _configuration.GetSection("weatherapi").Bind(options);


             ViewBag.ClientId = options.ClientId;
            ViewBag.ClientSecret = options.ClientSecret;


            return View();
        }
}
}
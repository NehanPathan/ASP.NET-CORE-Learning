using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewExample.Models;

namespace ViewExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]

        public IActionResult Index()
        {
            ViewData["appTitle"] = "ASP .Net Core Application";
            List<Person> people = new List<Person>
                {
                    new Person(){
                    Name = "Nehan",DateOfBirth=DateTime.Parse("2004-01-12"),Persongender=Gender.Male
                    },

                    new Person(){
                    Name = "Khan",DateOfBirth=DateTime.Parse("2004-07-21"),Persongender=Gender.Female
                    },

                    new Person(){
                    Name = "Pathan",DateOfBirth=DateTime.Parse("2004-11-26"),Persongender=Gender.Male
                    }
                };
                ViewData["people"] = people;
            return View();
        }

    }
}
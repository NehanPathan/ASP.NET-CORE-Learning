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
                    Name = "Pathan",DateOfBirth = null
                    //DateOfBirth = DateTime.Parse("2004-11-26"),Persongender=Gender.Male
                    }
                };
                // ViewData["people"] = people;
                // ViewBag.people = people;
            return View("Index", people);
        }

         [Route("person-details/{name}")]
          public IActionResult Detail(string? name)
        {
            if(name == null)
            return Content("Person name can't be null");

            List<Person> people = new List<Person>
                {
                    new Person(){
                    Name = "Nehan",DateOfBirth=DateTime.Parse("2004-01-12"),Persongender=Gender.Male
                    },

                    new Person(){
                    Name = "Khan",DateOfBirth=DateTime.Parse("2004-07-21"),Persongender=Gender.Female
                    },

                    new Person(){
                    Name = "Pathan",DateOfBirth = null
                    //DateOfBirth = DateTime.Parse("2004-11-26"),Persongender=Gender.Male
                    }
                };
                Person? matchingPerson = people.Where(person => person.Name == name).FirstOrDefault();
               return View(matchingPerson);
        }

    }
}
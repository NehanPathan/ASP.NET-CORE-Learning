using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/friends-list")]
        public IActionResult LoadFriendsList()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Friends",
                Persons = new List<Person>(){
                new Person() { PersonName = "Khan", JobTitle = "Manager" },
                new Person() { PersonName = "Nehan", JobTitle = "Developer" },
                new Person() { PersonName = "Pathan", JobTitle = "ProductManager" },

                }
            };
            return ViewComponent("Grid", new{
                grid = personGridModel
            });
        }
        

       
    }
}
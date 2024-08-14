using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
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

        [Route("/programming-languages")]
        public IActionResult ProgrammingLanguages()
        {
            ListModel listModel = new ListModel();
            listModel.ListTitle = "Programming Languages List";
            listModel.ListItems = new List<string>()
        {
            "c",
            "java",
            "c#",
            "python"
        };

            return PartialView("_ListPartialView", listModel);
        }
    }
}

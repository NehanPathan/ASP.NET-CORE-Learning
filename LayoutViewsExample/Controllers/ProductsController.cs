using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LayoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
       [Route("/products")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/search-products")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("/order-product")]
        public IActionResult Order()
        {
            return View();
        }

       
    }
}
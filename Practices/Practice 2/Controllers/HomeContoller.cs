using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_2.Models;

namespace Practice_2.Controllers
{
    public class HomeContoller : Controller
    {
       [Route("order")]
        
        public IActionResult Index(Order order)
        {
            //   Random random = new Random();
            //    string randomPart = random.Next(10000, 99999).ToString(); // Generates a random number between 1000 and 999
            //    return Ok($"OrderNumber: {randomPart}");

            if(!ModelState.IsValid){
                string error = string.Join("\n", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(error);
            }
            return View(order);
        }

       
    }
}
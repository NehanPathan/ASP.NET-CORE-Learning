
using Microsoft.AspNetCore.Mvc;
using Model_Validation_Example.Models;

namespace Model_Validation_Example.Controllers
{
    public class HomeController : Controller
    {

        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {

                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(error => error.ErrorMessage));
                return BadRequest(errors);
            }

            return Content($"{person}");
        }

    }
}
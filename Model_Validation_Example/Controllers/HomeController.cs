
using Microsoft.AspNetCore.Mvc;
using Model_Validation_Example.Models;

namespace Model_Validation_Example.Controllers
{
    public class HomeController : Controller
    {

        [Route("register")]
        public IActionResult Index([Bind(nameof(Person.PersonName), nameof(Person.Email), nameof(Person.Password), nameof(Person.ConfirmPassword))] Person person)
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
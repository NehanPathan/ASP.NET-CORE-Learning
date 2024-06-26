
using Microsoft.AspNetCore.Mvc;
using Model_Validation_Example.Models;

namespace Model_Validation_Example.Controllers
{
    public class HomeController : Controller
    {

        [Route("register")]
        public IActionResult Index(Person person)
        {
            return Content($"{person}");
        }

    }
}
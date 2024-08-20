using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Services;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICitiesService _citiesService;

        ////constructor
        //public HomeController(ICitiesService citiesService)
        //{
        //    //create object of CitiesService class
        //    _citiesService = citiesService;
        //}

        [Route("/")]
        public IActionResult Index([FromServices]ICitiesService _citiesService)
        {
           List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}

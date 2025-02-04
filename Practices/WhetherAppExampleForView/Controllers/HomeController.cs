using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WhetherAppExampleForView.Models;

namespace WhetherAppExampleForView.Controllers
{
    public class HomeController : Controller
    {
        List<CityWhether> cityWhether = new List<CityWhether>
        {
            new CityWhether(){
                CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33
            },
            new CityWhether(){
                CityUniqueCode = "NYC", CityName = "Ney York", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60
            },
            new CityWhether(){
                CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82
            }
        };

        [Route("/")]
        public IActionResult Index()
        {
            return View("Index", cityWhether);
        }
[Route("weather/{cityCode}")]
public IActionResult Detail(string cityCode)
{
    if (string.IsNullOrEmpty(cityCode))
        return Content("CityCode can't be null");

    CityWhether? matchingCityWhether = cityWhether
        .Where(x => x.CityUniqueCode == cityCode)
        .FirstOrDefault();


    return View(matchingCityWhether);
}
    }
}

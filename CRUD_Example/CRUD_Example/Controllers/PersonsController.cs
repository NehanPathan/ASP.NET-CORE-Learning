using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace CRUD_Example.Controllers
{
    public class PersonsController : Controller
    {
        //private field
        private readonly IPersonsService _personsService;

        //Constructor
        public PersonsController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [Route("persons/index")]
        [Route("/")]
        public IActionResult Index()
        {
            List<PersonResponse> persons = _personsService.GetAllPersons();
            return View(persons); //Views/Persons/Index.cshtml
        }
    }
}

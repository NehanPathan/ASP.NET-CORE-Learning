
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Practice.Controllers
{
    [Controller]
    public class HomeController
    {
        [Route("sayhello")]
        [Route("/")]
        public string Index()
        {
            return "Hello from Index";
        }

        [Route("about")]
        public string About()
        {
            return "Hello from About";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from Contact";
        }

    }
}
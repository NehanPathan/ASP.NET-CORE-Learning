
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Practice.Controllers
{
    public class HomeController
    {
        [Route("sayhello")]
        public string method1()
        {
            return "Hello from method1";
        }
    }
}
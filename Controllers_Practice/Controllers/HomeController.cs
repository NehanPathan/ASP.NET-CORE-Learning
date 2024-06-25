
using Controllers_Practice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Controllers_Practice.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            // return new ContentResult() { Content = "Hello from Index", ContentType = "text/plain" };
            // return Content("Hello from Index", "text/plain");
            return Content("<h1>Welcome</h1> <h2>Hello from Index</h2>", "text/html");

        }

        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Nehaan",
                LastName = "Khan",
                Age = 19
            };
            // return new JsonResult(person);
            return Json(person);
            // return "{ \"key\": \"value\"}";
        }

        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
            // return new VirtualFileResult("/Certificate.pdf", "application/pdf");
            return File("/Certificate.pdf", "application/pdf");
        }
        [Route("file-download2")]
        public PhysicalFileResult FileDownload2()
        {
            // return new PhysicalFileResult(@"C:\Users\patha\OneDrive\Desktop\ASP.NET Core Practice\Certificate.pdf", "application/pdf");
            return PhysicalFile(@"C:\Users\patha\OneDrive\Desktop\ASP.NET Core Practice\Certificate.pdf", "application/pdf");
        }

        [Route("file-download3")]
        public FileContentResult FileDownload3()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\patha\OneDrive\Desktop\ASP.NET Core Practice\Certificate.pdf");
            // return new FileContentResult(bytes, "application/pdf");
            return File(bytes, "application/pdf");
        }
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        //Url: /bookstore?bookid=5&isloggedin=true
        // public IActionResult IActionResultUse([FromQuery/FromRoute]int? bookid, bool? isloggedin)

        public IActionResult IActionResultUse(int? bookid, bool? isloggedin,[FromQuery] Book book)
        {
            //Book id should be applied
            if (bookid.HasValue == false)
            {
                // return new BadRequestResult();
                return BadRequest("Book id is not supplied or empty");
            }

            //Book id can't be less than or equal to 0
            if (bookid <= 0)
            {

                return BadRequest("Book id can't be less than or equal to 0");
            }
            
            if (bookid > 1000)
            {

                return NotFound("Book id can't be greater than 1000");
            }

            //isloggedin should be true
            if (isloggedin == false)
            {
                return StatusCode(401);

            }
            return Content($"Book id: {bookid}, Book: {book}", "text/plain");
           
        }

    }
}
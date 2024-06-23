
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
        [Route("bookstore")]
        //Url: /bookstore?bookid=5&isloggedin=true
        public IActionResult IActionResultUse()
        {
            //Book id should be applied
            if (!Request.Query.ContainsKey("bookid"))
            {
                // return new BadRequestResult();
                return BadRequest("Book id is not supplied");
            }

            //Book id can't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {

                return BadRequest("Book id can't be null or empty");
            }

            //Book id should be between 1 to 1000
            int bookId = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);
            if (bookId <= 0)
            {

                return BadRequest("Book id can't be less than or equal to zero");
            }
            if (bookId > 1000)
            {

                return NotFound("Book id can't be greater than 1000");
            }

            //isloggedin should be true
            if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
            {

                // return Unauthorized("User must be authenticated");
                // return StatusCode(401);
                return StatusCode(401, "User must be authenticated");

            }

            // return File("/Certificate.pdf", "application/pdf");
            //302 - Found - RedirectToActionResult
            // return new RedirectToActionResult("Books", "Store", new {id = bookId }); //302 - Found
            //return RedirectToAction("Books", "Store", new { id = bookId });

            //301 - Moved Permanently - RedirectToActionResult
            //return new RedirectToActionResult("Books", "Store", new { }, permanent: true); //301 - Moved Permanently
            //return RedirectToActionPermanent("Books", "Store", new { id = bookId });

            //302 - Found - LocalRedirectResult
            //return new LocalRedirectResult($"store/books/{bookId}"); //302 - Found
            //return LocalRedirect($"store/books/{bookId}"); //302 - Found

            //301 - Moved Permanently - LocalRedirectResult
            // return new LocalRedirectResult($"store/books/{bookId}", true); //301 - Moved Permanently
            //  return LocalRedirectPermanent($"/store/books/{bookId}"); //301 - Moved Permanently

            return Redirect($"store/books/{bookId}"); //302 - Found
            //return RedirectPermanent($"store/books/{bookId}"); //301 - Moved Permanently
        }

    }
}
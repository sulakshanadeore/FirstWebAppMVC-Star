using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC_Star.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            string time=ShowTime();

            return RedirectToAction("Greet", new { name = username,loggedintime=time });
        }

        [NonAction]
        public string ShowTime()
        { 
            return DateTime.Now.ToLongTimeString();
        }


        public ContentResult Greet(string name,string loggedintime)
        {

            return Content("Welcome to MVC " + name + "at " + loggedintime);
        }

        public ActionResult OpenGoogle()
        {

            return RedirectPermanent("https://www.google.com");
        }

        public ActionResult GoToHome()
        {
            return RedirectToAction("Greet");
        }

        public ActionResult OpenIndexOfHome()
        {

            return RedirectToAction("Index", "Home");
        }


    }
}

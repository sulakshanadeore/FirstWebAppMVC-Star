using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC_Star.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if (username=="Sam" && password=="Sam@123")
            {
                //  var localtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string s = "username=Sam, Role = Dev, Location = Pune";
                CookieOptions cookie = new CookieOptions();
                cookie.Expires = DateTime.Now.AddMinutes(30);
               cookie.HttpOnly = true;
                cookie.Secure = false;

                //Response.Cookies.Append("userdetails",username,cookie);
                Response.Cookies.Append("userdetails",s, cookie);
            }
           
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            string data=Request.Cookies["userdetails"];

            return Content("Welcome, "  +data);
        }
    }
}

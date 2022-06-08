using Microsoft.AspNetCore.Mvc;

namespace web4.Controllers
{
    public class LoginController : Controller
    {
        //login form
        public IActionResult Index()
        {
            return View();
        }

        //login check
        public IActionResult Login(string username, string password)
        {
            string result = null;
           if (username == "admin" && password == "123456")
            {
                result = "true";
            }
           else
            {
                result = "false";
            }
            ViewData["result"] = result;
            return View();
        }
    }
}

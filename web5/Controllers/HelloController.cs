using Microsoft.AspNetCore.Mvc;

namespace web5.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string name, string age)
        {
            if (name == null)
            {
                name = "N/A";
            } 
            string hello1 = "Hello " + name + " ! ";

            string hello2 = null;
            if (age == null)
            {
                hello2 = "Age is not defined !";
            } else
            {
                hello2 = "You are " + age + " year old";
            }
            ViewBag.Message1 = hello1;
            ViewData["Message2"] = hello2;
            return View();
        }
    }
}

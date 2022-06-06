using Microsoft.AspNetCore.Mvc;

namespace webdemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

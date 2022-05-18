using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Seagame()
        {
            string s1 = "Football";
            string s2 = "Swimming";
            ViewBag.Sport1 = s1;
            ViewBag.Sport2 = s2;
            ViewBag.Sport3 = "Billard";
            return View();
        }
    }
}

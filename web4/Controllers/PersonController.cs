using Microsoft.AspNetCore.Mvc;
using web4.Models;

namespace web4.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello(Person person)
        {
            return View(person);
        }
    }
}

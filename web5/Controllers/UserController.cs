using Microsoft.AspNetCore.Mvc;
using web5.Models;

namespace web5.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Input()
        {
            return View();
        }
        public IActionResult Output(User user)
        {
            return View(user);
        }
    }
}

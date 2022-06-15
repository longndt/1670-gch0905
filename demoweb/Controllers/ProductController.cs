using Microsoft.AspNetCore.Mvc;

namespace demoweb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

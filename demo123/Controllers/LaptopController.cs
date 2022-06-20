using demo123.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace demo123.Controllers
{
    public class LaptopController : Controller
    {
        protected readonly ApplicationDbContext context;
        public LaptopController (ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Laptop.ToList());
        }
    }
}

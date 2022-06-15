using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoweb.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var categories = context.Category.ToList();
            return View(categories);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = context.Category
                .Include(c => c.Products)
                .FirstOrDefault(m => m.Id == id)
            ;
            return View(category);
        }

        public IActionResult Delete (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = context.Category.Find(id);
            context.Category.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
           if (ModelState.IsValid) {
                context.Category.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = context.Category.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Category.Update(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}   

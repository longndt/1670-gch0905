using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using webdemo.Data;

namespace webdemo.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly DemoContext context;
        
        public EnrollmentController (DemoContext demoContext)
        {
            this.context = demoContext;
        }
        public IActionResult Index()
        {
            var enrollments = context.Enrollments.ToList();
            return View(enrollments);
        }
        
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            var course = context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .FirstOrDefault(m => m.EnrollmentId == id);
            return View(course);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var enrollment = context.Enrollments.Find(id);
            context.Enrollments.Remove(enrollment);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using webdemo.Data;

namespace webdemo.Controllers
{
    public class CourseController : Controller
    {
        private readonly DemoContext context;

        public CourseController(DemoContext demoContext)
        {
            this.context = demoContext;
        }
        
        //SELECT * FROM Course : View All
        public IActionResult Index()
        {
            var courses = context.Courses.ToList();
            return View(courses);
        }

        //SELECT * FROM COURSE WHERE CourseID = id : VIEW BY ID
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = context.Courses
                .Include(c => c.Enrollments)
                .ThenInclude(e => e.Student)
                .FirstOrDefault(m => m.CourseId == id);
            return View(course);
        }

        public IActionResult Delete (int? id)
        {
            if (id == null)
                return NotFound();
            var course = context.Courses.Find(id);
            context.Courses.Remove(course);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

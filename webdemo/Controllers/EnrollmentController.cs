using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using webdemo.Data;
using webdemo.Models;

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

        //render ra form Create Enrollment cho người dùng nhập liệu
        public IActionResult Create()
        {
            //lấy dữ liệu từ bảng Course và Student để đổ vào form
            //Create Enrollment cho người dùng lựa chọn
            var courses = context.Courses.ToList();
            var students = context.Students.ToList();
            ViewBag.Courses = courses;
            ViewBag.Students = students;
            return View();
        }

        //nhận & validate dữ liệu từ form Create Enrollment
        //sau đó lưu vào DB & redirect về trang Enrollment Index
        [HttpPost]
        public IActionResult Create(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                context.Enrollments.Add(enrollment);
                context.SaveChanges();
                return RedirectToAction("Index");
               // return RedirectToAction(nameof(Index));
            }
            return View(enrollment);
        }
        
        //render ra form Edit Enrollment
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var enrollment = context.Enrollments.Find(id);
            if (enrollment == null) {
                return NotFound();
            }
            var courses = context.Courses.ToList();
            var students = context.Students.ToList();
            ViewBag.Courses = courses;
            ViewBag.Students = students;
            return View(enrollment);
        }

        //xử lý dữ liệu từ form Edit Enrollment
        [HttpPost]
        public IActionResult Edit (Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                context.Enrollments.Update(enrollment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrollment);
        }
    }
}

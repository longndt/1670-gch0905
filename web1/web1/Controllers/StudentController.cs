using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web1.Models;

namespace web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            Student s1 = new Student(1, "Tuan", 20, 7);
            Student s2 = new Student(2, "Minh", 19, 8);
            Student s3 = new Student(3, "Phuong", 18, 10);
            List<Student> students = new List<Student>()
            {
                s1, s2, s3
            };
            ViewBag.Students = students;
            return View();
        }
    }
}

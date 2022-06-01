using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web4.Models;

namespace web4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string city = "Hanoi";
            int year = 2022;
            ViewBag.City = city;
            ViewData["year"] = year;

            Student s1 = new Student(1, "Minh", "minh@gmail.com", "Ha Noi");
                
            //render ra file "Index.cshtml" trong Views/Demo (mặc định)
            return View(s1); 

            //render ra file "Demo.csthml: trong Views/Home (tùy biến)
            //return View("~/Views/Home/Demo.cshtml");
            
        }
         
        public IActionResult Input()
        {
            return View();
        }

        public IActionResult Output(Person s)
        {
            return View(s);
        }
        
        public IActionResult StudentList()
        {
            Student s1 = new Student(1, "Minh", "minh@gmail.com", "Ha Noi");
            Student s2 = new Student(2, "Hoang", "hoang@gmail.com", "HCM City");
            Student s3 = new Student(3, "Tien", "tien@gmail.com", "Da Nang");

            List<Student> students = new List<Student>()
            {
                s1,s2,s3
            };
            Student s4 = new Student(4, "Cong", "cong@gmail.com", "Hai Phong");
            students.Add(s4);
            return View(students);
        }
    }
}

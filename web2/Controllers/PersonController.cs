using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web2.Models;

namespace web2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult List()
        {
            Person p1 = new Person(1, "Minh", 20, "Ha Noi");
            Person p2 = new Person(2, "Nam", 23, "Hai Phong");
            Person p3 = new Person(3, "Tung", 24, "Nam Dinh");
            Person p4 = new Person(4, "Hoang", 30, "Quang Ninh");
            List<Person> persons = new List<Person>()
            {
                p1,p2,p3,p4
            };
            //cách 3: để pass dữ liệu từ Controller sang View sử dụng @model
            return View(persons);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using webdemo.Data;
using webdemo.Models;

namespace webdemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly DemoContext _context;
        public StudentController(DemoContext context)
        {
            _context = context;
        }

        //READ feature: SELECT * FROM Student

        //Method 1: synchronous (đồng bộ) 
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            var total = _context.Students.ToList().Count();
            //ViewBag.Total = total;
            ViewData["total"] = total;
            return View(students);
        }

        //Method 2: asynchronous (bất đồng bộ) => recommended
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Students.ToListAsync());
        //}

        //READ feature: SELECT * FROM Student WHERE Id = id
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                   .Include(s => s.Enrollments)
                   .ThenInclude(e => e.Course)
                   .FirstOrDefaultAsync(m => m.Id == id);
            return View(student);
        }

        //DELETE FROM Student WHERE Id = id
        public IActionResult Delete (int? id)
        {
            if (id == null)
                return NotFound();
            var student = _context.Students.Find(id);
            _context.Remove(student);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        //CREATE feature: INSERT INTO Student (LastName, FirstMidName, EnrollmentDate) VALUES (?,?,?)
        //tạo hàm để render ra form Create Student
        public IActionResult Create()
        {
            return View(); 
        }

        //tạo hàm để nhận dữ liệu từ form Create Student
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //UPDATE feature: UPDATE Student SET .... WHERE StudentId = id
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Update(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}

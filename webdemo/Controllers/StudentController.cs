﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using webdemo.Data;

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
        //public IActionResult Index()
        //{
        //    return View(_context.Students.ToList());
        //}

        //Method 2: asynchronous (bất đồng bộ) => recommended
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

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
    }
}

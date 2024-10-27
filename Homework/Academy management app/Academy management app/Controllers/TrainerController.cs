using Microsoft.AspNetCore.Mvc;

namespace Academy_management_app.Controllers
{
    using Academy_management_app.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class TrainerController : Controller
    {
        private readonly AcademyContext _context;

        public TrainerController(AcademyContext context)
        {
            _context = context;
        }

        
        public IActionResult Dashboard()
        {
            return View();
        }

        // View Students
        public IActionResult ViewStudents()
        {
            var students = _context.Students.Include(s => s.Subjects).ToList();
            return View(students);
        }

        
    }

}

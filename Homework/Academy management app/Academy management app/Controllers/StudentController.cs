using Academy_management_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academy_management_app.Controllers
{
    public class StudentController : Controller
    {
        private readonly AcademyContext _context;

        public StudentController(AcademyContext context)
        {
            _context = context;
        }

       
        public IActionResult Dashboard()
        {
            return View();
        }

        
        public IActionResult ViewGrades()
        {
            
            return View();
        }
    }
}

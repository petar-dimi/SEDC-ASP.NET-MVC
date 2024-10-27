using Microsoft.AspNetCore.Mvc;

namespace Academy_management_app.Controllers
{
    using Academy_management_app.Models;
    using Microsoft.AspNetCore.Mvc;

    public class AdminController : Controller
    {
        private readonly AcademyContext _context;

        public AdminController(AcademyContext context)
        {
            _context = context;
        }

        
        public IActionResult Dashboard()
        {
            return View();
        }

       
        public IActionResult ManageUsers()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        
    }

}

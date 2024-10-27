using Academy_management_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academy_management_app.Controllers
{
    public class AuthController : Controller
    {
        private readonly AcademyContext _context;

        public AuthController(AcademyContext context)
        {
            _context = context;
        }

        // Login page
        public IActionResult Login()
        {
            return View();
        }

        // Handle login
        [HttpPost]
        public IActionResult Login(User user)
        {
            var loggedUser = _context.Users
                .FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password); // Use hashed password in production

            if (loggedUser != null)
            {
                // Set user in session or claims
                return RedirectToAction("Dashboard", loggedUser.Role);
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View(user);
        }

        // Logout logic here
    }
}


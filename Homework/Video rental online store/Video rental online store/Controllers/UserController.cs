using Microsoft.AspNetCore.Mvc;
using Video_rental_online_store.Data;

namespace Video_rental_online_store.Controllers
{
    public class UserController : Controller
    {
        private readonly VideoRentalDbContext db;

        public UserController(VideoRentalDbContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string cardNumber)
        {
            var user = db.Users.FirstOrDefault(u => u.CardNumber == cardNumber);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                return RedirectToAction("Dashboard", "Movie");
            }
            ViewBag.Message = "Invalid Card Number";
            return View();
        }
    }
}

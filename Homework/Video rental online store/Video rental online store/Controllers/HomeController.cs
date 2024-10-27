using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Video_rental_online_store.Data;
using Video_rental_online_store.Models;

namespace Video_rental_online_store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ListMovies()
        {
            return View();
        }
    }
}


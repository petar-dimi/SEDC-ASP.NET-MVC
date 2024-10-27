using Microsoft.AspNetCore.Mvc;
using Video_rental_online_store.Data;
using Video_rental_online_store.Models;

namespace Video_rental_online_store.Controllers
{
    public class MovieController : Controller
    {
        private readonly VideoRentalDbContext db;

        public MovieController(VideoRentalDbContext context)
        {
            db = context;
        }

        public IActionResult ListMovies()
        {
           
            return View();
        }

        public IActionResult MovieDetails(int id)
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult RentMovie(int movieId)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            var movie = db.Movies.Find(movieId);

            if (userId != null && movie != null && movie.Quantity > 0)
            {
                movie.Quantity--;
                db.Rentals.Add(new Rental { MovieId = movie.Id, UserId = userId.Value, RentedOn = DateTime.Now });
                db.SaveChanges();
                return RedirectToAction("ListMovies");
            }

            ViewBag.Message = "Movie not available for rent.";
            return RedirectToAction("MovieDetails", new { id = movieId });
        }

        [HttpPost]
        public IActionResult ReturnMovie(int rentalId)
        {
            var rental = db.Rentals.Find(rentalId);
            if (rental != null && rental.ReturnedOn == null)
            {
                rental.ReturnedOn = DateTime.Now;
                var movie = db.Movies.Find(rental.MovieId);
                if (movie != null) movie.Quantity++;
                db.SaveChanges();
                return RedirectToAction("ListRentedMovies");
            }

            ViewBag.Message = "Rental not found or already returned.";
            return RedirectToAction("Dashboard", "User");
        }
    }
}

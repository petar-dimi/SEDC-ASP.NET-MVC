using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Video_rental_online_store.Models;

namespace Video_rental_online_store.Data
{
    public class VideoRentalDbContext : DbContext
    {
        public VideoRentalDbContext(DbContextOptions<VideoRentalDbContext> options)
                : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}

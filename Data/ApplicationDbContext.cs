using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bookings> Booking { get; set; }
        public DbSet<Inventory> Inventory { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }

    }
}

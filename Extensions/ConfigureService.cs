using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Repository;

namespace VehicleManagementSystem.Extensions
{
    public static class ConfigureService
    {
        public static void AddDenpendencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IBookingsRepository, BookingsRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
        }
    }
}

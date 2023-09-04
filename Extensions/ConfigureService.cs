using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Data;

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
        }
    }
}

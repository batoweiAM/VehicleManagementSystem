using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Repository
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAllVehicles();
        Task<Vehicle> GetVehiclesById(Guid id);
        Task<IEnumerable<Vehicle>> GetVehicleByMake(string make);
        Task<IEnumerable<Vehicle>> GetVehiclesByModel(string model);
        Task<IEnumerable<Vehicle>> GetVehiclesByPriceRange(decimal minPrice, decimal maxPrice);
        Task<IEnumerable<Vehicle>> GetVehiclesByProductionYear(int year);
    }
}

using System.Collections.Generic;
using System.Reflection;
using System;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace VehicleManagementSystem.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //        1.  Retrieve a list of all available vehicles.
        //        2. Get details of a specific vehicle by its ID.
        //        3.  Filter vehicles by make (e.g., Ford,
        //        4.  Filter vehicles by model (e.g., Camry
        //        5.  Filter vehicles within a specified price range.
        //        6. Filter vehicles by production year.


        public async Task<IEnumerable<Vehicle>> GetAllVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<Vehicle> GetVehiclesById(Guid id)
        {
            return await _context.Vehicles.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<IEnumerable<Vehicle>> GetVehicleByMake(string make)
        {
            return await _context.Vehicles.Where(v => v.Make == make).ToListAsync();
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByModel(string model)
        {
            return await _context.Vehicles.Where(v => v.Model == model).ToListAsync();
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return await _context.Vehicles.Where(v => v.Price >= minPrice && v.Price <= maxPrice).ToListAsync();    
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByProductionYear(int year)
        {
            return await _context.Vehicles.Where(v => v.ProductionYear == year).ToListAsync();
        }
    }
}

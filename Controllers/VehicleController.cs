using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Repository;

namespace VehicleManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetAllVehicles()
        {
            var vehicles = await _vehicleRepository.GetAllVehicles();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehiclesById(Guid id)
        {
            var vehicles = await _vehicleRepository.GetVehiclesById(id);
            if(vehicles == null)
            {
                return NotFound();
            }
            return Ok(vehicles);
        }

        [HttpGet("make/{make}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehiclesByMake(string make)
        {
            var vehicles = _vehicleRepository.GetVehicleByMake(make);
            return Ok(vehicles);
        }

        [HttpGet("model/{model}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehiclesByModel(string model)
        {
            var vehicles = _vehicleRepository.GetVehiclesByModel(model);
            return Ok(vehicles);
        }

        [HttpGet("Price")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehiclesByPriceRange([FromQuery] decimal minPrice, [FromQuery]decimal maxPrice)
        {
            var vehicles = _vehicleRepository.GetVehiclesByPriceRange(minPrice, maxPrice);
            return Ok(vehicles);
        }

        [HttpGet("year/{year}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicleByProductionYear(int year)
        {
            var vehicles = _vehicleRepository.GetVehiclesByProductionYear(year);
            return Ok(vehicles);
        }
    }
}

using Microsoft.Net.Http.Headers;

namespace VehicleManagementSystem.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int Quality { get; set; }
    }
}

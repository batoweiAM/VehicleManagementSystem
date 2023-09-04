namespace VehicleManagementSystem.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int ProductionYear { get; set; }
    }
}

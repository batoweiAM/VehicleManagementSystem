namespace VehicleManagementSystem.Models
{
    public class Bookings
    {
        public int Id { get; set; }
        public int vehicleId { get; set; }
        public int UserId { get; set; }
        public bool IsSold { get; set; }
    }
}

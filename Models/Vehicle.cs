
namespace car_log.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public VehicleType Type { get; set; }
        public string Notes { get; set; }
    }
    private enum VehicleType
    {
        Automobile,
        Plane
    }
}

namespace car_log.Models
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public VehicleType Type { get; set; }
        public string Notes { get; set; }
    }
    public enum VehicleType
    {
        Automobile,
        Plane
    }
}
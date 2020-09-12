using Microsoft.EntityFrameworkCore;

namespace car_log.Data
{
    public class CarLogContext : DbContext
    {
        public CarLogContext (DbContextOptions<CarLogContext> options)
        : base(options)
        {

        }
        public DbSet<car_log.Models.Vehicle> Vehicle { get; set; }
        public DbSet<car_log.Models.Record> Record { get; set; }
    }
}
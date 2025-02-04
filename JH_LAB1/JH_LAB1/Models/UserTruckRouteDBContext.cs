using Microsoft.EntityFrameworkCore;
namespace JH_LAB1.Models
{
    public class UserTruckRouteDBContext:DbContext
    {
        public UserTruckRouteDBContext(DbContextOptions<UserTruckRouteDBContext> dbContextOptions):base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckWorkshop> TruckWorkshops { get; set; }
    }
}

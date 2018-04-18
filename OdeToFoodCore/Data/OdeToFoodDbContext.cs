using Microsoft.EntityFrameworkCore;
using OdeToFoodCore.Models;

namespace OdeToFoodCore.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options) 
            : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

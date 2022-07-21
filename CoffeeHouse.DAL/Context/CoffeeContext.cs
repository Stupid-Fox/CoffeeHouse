using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<CoffeeEntity> Coffees { get; set; } = null!;
        public DbSet<CoffeeEntity> Cups { get; set; } = null!;
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
                
        }       
    }
}

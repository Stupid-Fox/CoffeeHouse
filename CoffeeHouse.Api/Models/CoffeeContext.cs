using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.Api.Models
{

    public class CoffeeContext : DbContext
    {
        public DbSet<Coffee> Users { get; set; }
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

}

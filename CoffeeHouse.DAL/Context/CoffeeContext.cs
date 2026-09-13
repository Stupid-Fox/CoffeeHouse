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
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeEntity>().HasData(
                    new CoffeeEntity { Id = 1, Name = "Latte", Cost = 37 , MakeTime = 15, Temperature = 50},
                    new CoffeeEntity { Id = 2, Name = "Capuchino", Cost = 41, MakeTime = 12, Temperature = 40 },
                    new CoffeeEntity { Id = 3, Name = "Coffee", Cost = 24, MakeTime = 10, Temperature = 30 }
            );
            modelBuilder.Entity<CupEntity>().HasData(
                    new CupEntity { Id = 1, Cost = 10, Material = 123, Name = "Food1", Volume = 22 }
            );
        }
    }
}

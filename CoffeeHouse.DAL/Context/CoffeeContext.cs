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
                    new CoffeeEntity { Id = 1, Name = "Tom", Cost = 37 , MakeTime = 12, Temperature = 14},
                    new CoffeeEntity { Id = 2, Name = "Bob", Cost = 41, MakeTime = 12, Temperature = 14 },
                    new CoffeeEntity { Id = 3, Name = "Sam", Cost = 24, MakeTime = 12, Temperature = 14 }
            );
            modelBuilder.Entity<CupEntity>().HasData(
                    new CupEntity { Id = 1, Cost = 10, Material = 123, Name = "Food1", Volume = 22 }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CoffeeHouse.DAL.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<CoffeeEntity> Coffees { get; set; } = null!;
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeEntity>().HasData(
                    new CoffeeEntity { Id = 1, Name = "Latte" , Cost = 12},
                    new CoffeeEntity { Id = 2, Name = "Capuchino", Cost =15},
                    new CoffeeEntity { Id = 3, Name = "Coffee" , Cost=8 }
            );
        }
    }
}

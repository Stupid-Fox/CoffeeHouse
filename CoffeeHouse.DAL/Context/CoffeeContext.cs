using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CoffeeHouse.Api.Models
{
    public class CoffeeContext : DbContext
    {
        public DbSet<Coffee> Coffes { get; set; } = null!;
        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coffee>().HasData(
                    new Coffee { Id = 1, Name = "Latte" , Cost = 12},
                    new Coffee { Id = 2, Name = "Capuchino", Cost =15},
                    new Coffee { Id = 3, Name = "Coffee" , Cost=8 }
            );
        }
    }
}

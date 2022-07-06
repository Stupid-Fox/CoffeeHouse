using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CoffeeHouse.Api.Models
{
    public class CoffeeContext : DbContext
    {

        public DbSet<Coffee> Coffees { get; set; }


        public CoffeeContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CoffeeHousedb;Trusted_Connection=True;");
        }
    }
}

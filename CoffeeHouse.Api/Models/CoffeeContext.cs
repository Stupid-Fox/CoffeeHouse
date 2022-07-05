using CoffeeHouse.Api.Models;
using Microsoft.EntityFrameworkCore;
public class CoffeeContext : DbContext
{
    public DbSet<Coffee> Users { get; set; } = null!;
    public CoffeeContext(DbContextOptions<CoffeeContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coffee>().HasData(
                new Coffee { Id = 1, Name = "Tom", Cost = 37 },
                new Coffee{ Id = 2, Name = "Bob", Cost = 41 },
                new Coffee { Id = 3, Name = "Sam", Cost = 24 }
        );
    }
}
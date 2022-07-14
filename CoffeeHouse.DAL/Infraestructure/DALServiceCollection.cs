using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeHouse.DAL.Di
{
    public static class DALServiceCollection
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddScoped<ICoffeeRepository, CoffeeRepository>();
            services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connection));
          
        }
    }
}

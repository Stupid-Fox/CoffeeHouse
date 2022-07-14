using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeHouse.DAL.Di
{
    public static class Di
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<CoffeeContext>(options => options.UseSqlServer(connection));
            services.AddScoped<ICoffeeRepository, CoffeeRepository>();
            services.AddTransient<ICoffeeRepository, CoffeeRepository>();
            return services;
        }

    }
}

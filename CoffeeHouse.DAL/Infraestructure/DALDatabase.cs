using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DALDatabase
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IGenericRepository<CoffeeEntity>, GenericRepository<CoffeeEntity>>();
            services.AddScoped<IGenericRepository<CupEntity>, GenericRepository<CupEntity>>();
            services.AddDbContext<CoffeeContext>(options => 
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        }
    }
}

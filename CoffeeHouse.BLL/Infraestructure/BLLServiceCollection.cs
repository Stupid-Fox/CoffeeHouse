using CoffeeHouse.BLL.Services;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Di;
using CoffeeHouse.DAL.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace CoffeeHouse.BLL.Di
{
    public static class BLLServiceCollection
    {
       public static void AddBLLDependencies(this IServiceCollection services, IConfiguration config)
        {      
            services.AddScoped<ICoffeeService, CoffeeService>();
            services.AddDatabase(config);
        }
       
    }
}

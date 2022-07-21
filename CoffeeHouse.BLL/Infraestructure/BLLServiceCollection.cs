using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Models;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BLLServiceCollection
    {
        public static void AddBLLServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IGenericService<CoffeeModel>, GenericService<CoffeeModel, CoffeeEntity>>();
            services.AddScoped<IGenericService<CupModel>, GenericService<CupModel, CupEntity>>();
            services.AddDatabase(config);
        }
    }
}

using CoffeeHouse.BLL.Services;
using CoffeeHouse.BLL.Services.Intarfeces;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BLLServiceCollection
    {
        public static void AddBLLServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ICoffeeService, CoffeeService>();
            services.AddDatabase(config);
        }
    }
}

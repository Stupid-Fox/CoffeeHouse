using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Di
{
    public static class Di
    {

        public static void AddDALDependencies(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<ICoffeeRepository, CoffeeRepository>();
        }
    }
}

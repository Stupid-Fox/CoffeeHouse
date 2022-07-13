using CoffeeHouse.BLL.Services;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Di;
using CoffeeHouse.DAL.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Di
{
    public static class Di
    {
       public static void AddBLLDependencies(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<ICoffeeService, CoffeeService>();
        }

     

       
    }
}

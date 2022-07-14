﻿using CoffeeHouse.BLL.Services;
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
       public static IServiceCollection AddBLLDependencies(this IServiceCollection services)
        {      
            services.AddScoped<ICoffeeService, CoffeeService>();
            return services;
        }
       
    }
}

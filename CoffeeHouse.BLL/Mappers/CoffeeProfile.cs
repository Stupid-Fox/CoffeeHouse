using AutoMapper;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Mappers
{
    internal class CoffeeProfile : Profile
    {
        public CoffeeProfile()
        {
            CreateMap<CoffeeModel, CoffeeEntity>();
        }
    }
}

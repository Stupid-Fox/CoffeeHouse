using AutoMapper;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.DAL.Models;

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

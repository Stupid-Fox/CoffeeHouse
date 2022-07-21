using AutoMapper;
using CoffeeHouse.Api.ViewModels;
using CoffeeHouse.BLL.Models;

namespace CoffeeHouse.Api.CoffeeViewMappers
{
    public class CoffeeViewProfile: Profile
    {
        public CoffeeViewProfile()
        {
            CreateMap<CoffeeViewModel, CoffeeModel>().ReverseMap();
        }
    }
}

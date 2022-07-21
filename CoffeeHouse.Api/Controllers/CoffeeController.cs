using AutoMapper;
using CoffeeHouse.Api.Controllers;
using CoffeeHouse.Api.ViewModels;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using Microsoft.AspNetCore.Mvc;


namespace Pets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : GenericController<CoffeeViewModel, CoffeeModel>
    {
        public CoffeeController(IGenericService<CoffeeModel> service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}

using AutoMapper;
using CoffeeHouse.Api.ViewModels;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using Microsoft.AspNetCore.Mvc;


namespace CoffeeHouse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupController : GenericController<CupViewModel, CupModel>
    {
        public CupController(IGenericService<CupModel> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}

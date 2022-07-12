using AutoMapper;
using CoffeeHouse.Api.ViewModels;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICoffeeService _service;
        public CoffeeController(ICoffeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CoffeeViewModel> TakeCoffeeHouseMenu()
        {
            var coffeeHouseMenu = _service.TakeCoffeeHouseMenu();
            return _mapper.Map<IEnumerable<CoffeeModel>, IEnumerable<CoffeeViewModel>>(coffeeHouseMenu);
        }

        [HttpGet("{id}")]
        public CoffeeViewModel FindCoffee(int id)
        {
            var coffee = _service.FindCoffee(id);
            return _mapper.Map<CoffeeModel, CoffeeViewModel>(coffee);
        }

        [HttpPost]
        public void AddNewCoffee(CoffeeViewModel item)
        {
            var newCoffee = _mapper.Map<CoffeeViewModel, CoffeeModel>(item);
            _service.AddNewCoffee(newCoffee);
        }

        [HttpPut]
        public void ChangeCoffeeInformation(CoffeeViewModel item)
        {
            var coffee = _mapper.Map<CoffeeViewModel, CoffeeModel>(item);
            _service.ChangeCoffeeInformation(coffee);
        }

        [HttpDelete("{id}")]
        public void RemoveCoffee(int id)
        {
            _service.RemoveCoffee(id);
        }
    }
}
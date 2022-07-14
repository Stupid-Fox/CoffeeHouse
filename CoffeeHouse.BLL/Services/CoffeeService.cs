using AutoMapper;
using CoffeeHouse.BLL.Di;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Di;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly IMapper _mapper;

        private readonly ICoffeeRepository _repository;
        public CoffeeService(ICoffeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CoffeeModel> TakeCoffeeHouseMenu()
        {
            return _mapper.Map<IEnumerable<CoffeeEntity>, IEnumerable<CoffeeModel>>(_repository.TakeCoffeeHouseMenu());
        }

        public CoffeeModel FindCoffee(int id)
        {
            return _mapper.Map<CoffeeEntity, CoffeeModel>(_repository.FindCoffee(id));
        }    

        public void AddNewCoffee (CoffeeModel item)
        {
            _repository.AddNewCoffee(_mapper.Map<CoffeeModel, CoffeeEntity>(item));
        }

        public void ChangeCoffeeInformation(CoffeeModel item)
        {
            _repository.ChangeCoffeeInformation(_mapper.Map<CoffeeModel, CoffeeEntity>(item));
        }

        public void RemoveCoffee(int id)
        {
            _repository.RemoveCoffee(id);
        }
    }
}

using AutoMapper;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.BLL.Services.Intarfeces;
using CoffeeHouse.DAL.Controllers;
using CoffeeHouse.DAL.Models;

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

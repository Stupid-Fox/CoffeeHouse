using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.DAL.Controllers
{
    public interface ICoffeeRepository 
    {
        IEnumerable<CoffeeEntity> TakeCoffeeHouseMenu();
        CoffeeEntity FindCoffee(int id);
        void AddNewCoffee(CoffeeEntity item);
        void ChangeCoffeeInformation(CoffeeEntity item);
        void RemoveCoffee(int id);
    }
}
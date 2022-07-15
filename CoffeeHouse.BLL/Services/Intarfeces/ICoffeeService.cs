using CoffeeHouse.BLL.Models;

namespace CoffeeHouse.BLL.Services.Intarfeces
{
    public interface ICoffeeService
    {
        IEnumerable<CoffeeModel> TakeCoffeeHouseMenu();
        CoffeeModel FindCoffee(int id);
        void AddNewCoffee(CoffeeModel item);
        void ChangeCoffeeInformation(CoffeeModel item);
        void RemoveCoffee(int id);
    }
}

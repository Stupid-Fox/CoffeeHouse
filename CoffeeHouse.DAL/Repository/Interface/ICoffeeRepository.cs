using CoffeeHouse.Api.Models;
using CoffeeHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
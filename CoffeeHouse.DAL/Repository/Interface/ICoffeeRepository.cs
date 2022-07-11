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
        IEnumerable<Coffee> TakeCoffeeHouseMenu();
        Coffee FindCoffee(int id);
        void AddNewCoffee(Coffee item);
        void ChangeCoffeeInformation(Coffee item);
        void RemoveCoffee(int id);
    }
}
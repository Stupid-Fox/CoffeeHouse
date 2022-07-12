using CoffeeHouse.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Services.Intarfeces
{
    internal interface ICoffeeService
    {
        IEnumerable<CoffeeModel> TakeCoffeeHouseMenu();
        CoffeeModel FindCoffee(int id);
        void AddNewCoffee(CoffeeModel item);
        void ChangeCoffeeInformation(CoffeeModel item);
        void RemoveCoffee(int id);
    }
}

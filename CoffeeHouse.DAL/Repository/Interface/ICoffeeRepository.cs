using CoffeeHouse.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Controllers
{
    public interface ICoffeeRepository 
    {

        IEnumerable<Coffee> GetAll();
        Coffee GetById(int id);
        IEnumerable<Coffee> Find(Func<Coffee, Boolean> predicate);
        void Create(Coffee item);
        void Update(Coffee item);
        void Delete(int id);
    }
}
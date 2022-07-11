using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Repository
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private  CoffeeContext _context;

        public void CoffeeController(CoffeeContext context)
        {
            _context = context;
        }

     
        public IEnumerable<Coffee> TakeCoffeeHouseMenu()
        {
            return _context.Coffees.ToList();
        }

        
        public Coffee FindCoffee(int id)
        {
            var coffee = _context.Coffees.Find(id);
            if (coffee == null)
                throw new ArgumentNullException("Object cannot be null", nameof(coffee));
            return coffee;
        }

   
        public void AddNewCoffee(Coffee coffee)
        {
            _context.Coffees.Add(coffee);
            _context.SaveChanges();
        }

      
        public void ChangeCoffeeInformation(Coffee coffee)
        {
            _context.Update(coffee);
            _context.SaveChanges();
        }

        public void RemoveCoffee(int id)
        {
            var dbCoffee = _context.Coffees.Find(id);
            _context.Coffees.Remove(dbCoffee);
            _context.SaveChanges();
            if (dbCoffee == null)
            {
                throw new ArgumentNullException("Object cannot be null", nameof(dbCoffee));
            }
        }
    }
}

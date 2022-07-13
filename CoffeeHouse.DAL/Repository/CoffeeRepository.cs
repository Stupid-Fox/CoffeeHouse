using CoffeeHouse.DAL.Models;
using CoffeeHouse.DAL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CoffeeHouse.DAL.Di;

namespace CoffeeHouse.DAL.Repository
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private  CoffeeContext _context;

        public void ConfigureServices(IServiceCollection services, IConfiguration config)
        {
            services.AddDALDependencies(config);
        }

        public void CoffeeController(CoffeeContext context)
        {
            _context = context;
        }

     
        public IEnumerable<CoffeeEntity> TakeCoffeeHouseMenu()
        {
            return _context.Coffees.ToList();
        }

        
        public CoffeeEntity FindCoffee(int id)
        {
            var coffee = _context.Coffees.Find(id);
            if (coffee == null)
                throw new ArgumentNullException("Object cannot be null", nameof(coffee));
            return coffee;
        }

   
        public void AddNewCoffee(CoffeeEntity coffee)
        {
            _context.Coffees.Add(coffee);
            _context.SaveChanges();
        }

      
        public void ChangeCoffeeInformation(CoffeeEntity coffee)
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

using CoffeeHouse.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly CoffeeContext _context;
        public CoffeeController(CoffeeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Coffee> GetAllCoffes()
        {
            return _context.Coffees.ToList();
        }

        [HttpGet("{id}")]
        public Coffee GetCoffee(int id)
        {
            var coffee = _context.Coffees.Find(id);
            if (coffee == null)
                throw new ArgumentNullException("Object cannot be null", nameof(coffee));
            return coffee;
        }

        [HttpPost]
        public void AddNewCoffee(Coffee coffee)
        {
            _context.Coffees.Add(coffee);
            _context.SaveChanges();     
        }

        [HttpPut]
        public void PutCoffee(Coffee coffee)
        {
            _context.Update(coffee);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteCoffee(int id)
        {
            var dbCoffee =  _context.Coffees.Find(id);
            _context.Coffees.Remove(dbCoffee);
            _context.SaveChanges();
            if (dbCoffee == null)
            {
                throw new ArgumentNullException("Object cannot be null", nameof(dbCoffee));
            }
        }
    }
}
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
        public async Task<ActionResult<IEnumerable<Coffee>>> GetAll()
        {
            return Ok(await _context.Coffees.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Coffee>>> Get(int id)
        {
            var coffee = await _context.Coffees.FindAsync(id);
            if (coffee == null)
                return NotFound();
            return Ok(coffee);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Coffee>>> Post(Coffee coffee)
        {
            _context.Coffees.Add(coffee);
            await _context.SaveChangesAsync();
            return Ok(coffee);
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<Coffee>>> Put(Coffee request)
        {
            var dbCoffee = await _context.Coffees.FindAsync(request.Id);
            if (dbCoffee == null)
                return BadRequest("Coffee not found");

            dbCoffee.Cost = request.Cost;
            dbCoffee.MakeTime = request.MakeTime;
            dbCoffee.Name = request.Name;

            _context.Entry(dbCoffee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(dbCoffee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Coffee>>> Delete(int id)
        {
            var dbCoffee = await _context.Coffees.FindAsync(id);
            if (dbCoffee == null)
                return BadRequest("Coffee not found");

            _context.Coffees.Remove(dbCoffee);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }

}

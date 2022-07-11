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
       
        public CoffeeController()
        {
           
        }

        [HttpGet]
        public void TakeCoffeeHouseMenu()
        {
            
        }

        [HttpGet("{id}")]
        public void FindCoffee(int id)
        {

        }

        [HttpPost]
        public void AddNewCoffee()
        {

        }

        [HttpPut]
        public void ChangeCoffeeInformation()
        {
           
        }

        [HttpDelete("{id}")]
        public void RemoveCoffee()
        {
            
        }
    }
}
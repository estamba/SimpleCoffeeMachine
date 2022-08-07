using Microsoft.AspNetCore.Mvc;
using SimpeCoffeeMachine.Models;
using SimpleCoffeeMachine.Core.Interfaces;

namespace SimpeCoffeeMachine.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService coffeeService;

        public CoffeeController(ICoffeeService coffeeService)
        {
            this.coffeeService = coffeeService;
        }
        [HttpGet]
        public IActionResult Prepare()
        {
            return Ok("The coffee machine is ready :)");
        }
        [HttpPost]
        public IActionResult Prepare(CoffeeRequest coffeeRequest)
        {
            var coffee = coffeeService.Prepare(coffeeRequest.Type, coffeeRequest.Volume);
            return Ok(coffee);
        }
    }
}

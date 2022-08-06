using Microsoft.AspNetCore.Mvc;
using SimpeCoffeeMachine.Models;

namespace SimpeCoffeeMachine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Prepare(CoffeeRequest request)
        {
            return Ok();
        }
    }
}

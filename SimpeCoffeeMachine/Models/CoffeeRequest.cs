using SimpleCoffeeMachine.Core.Domain.Models;

namespace SimpeCoffeeMachine.Models
{
    public class CoffeeRequest
    {
        public CoffeeType Type { get; set; }
        public CoffeeVolume Volume { get; set; }
    }
}

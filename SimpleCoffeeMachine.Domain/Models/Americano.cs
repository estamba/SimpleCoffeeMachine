using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Americano : Coffee
    {
        public Americano(CoffeeVolume volume) : base(CoffeeType.Americano, volume)
        {
        }
    }
}

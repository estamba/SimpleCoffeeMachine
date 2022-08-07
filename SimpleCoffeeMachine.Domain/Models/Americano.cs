using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Americano : Coffee
    {
        public Americano(CoffeeType type, CoffeeVolume volume) : base(type, volume)
        {
        }
    }
}

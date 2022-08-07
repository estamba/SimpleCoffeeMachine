using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Expresso : Coffee
    {
        public Expresso(CoffeeVolume volume) : base(CoffeeType.Expresso, volume)
        {
        }
    }
}

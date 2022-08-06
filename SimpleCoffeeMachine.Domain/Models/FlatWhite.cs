using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class FlatWhite:Coffee
    {
        public FlatWhite(CoffeeType type, CoffeeVolume volume) : base(type, volume)
        {

        }
    }
}

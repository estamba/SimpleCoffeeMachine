using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class FlatWhite:Coffee
    {
        public FlatWhite(CoffeeVolume volume) : base(CoffeeType.Flatwhite, volume)
        {

        }
    }
}

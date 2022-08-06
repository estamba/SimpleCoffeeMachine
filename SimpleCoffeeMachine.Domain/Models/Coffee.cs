using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public abstract class Coffee
    {
        public Coffee(CoffeeType type, CoffeeVolume volume)
        {
            this.Type = type;
            this.Volume = volume;
        }
        public CoffeeType Type { get; }
        public CoffeeVolume Volume { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Coffee
    {
        public Coffee(CoffeeType type, double volume)
        {
            this.Type = type;
            this.Volume = volume;
        }
        public CoffeeType Type { get; }
        public double Volume { get; }
    }
}

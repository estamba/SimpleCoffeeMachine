using SimpleCoffeeMachine.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Interfaces
{
    public interface ICoffeeMakerFactory
    {
        ICoffeeMaker CreateCoffeeMaker(CoffeeType coffeeType)
    }
}

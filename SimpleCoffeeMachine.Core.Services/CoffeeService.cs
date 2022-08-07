using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ICoffeeMakerFactory coffeeMakerFactory;

        public CoffeeService(ICoffeeMakerFactory coffeeMakerFactory)
        {
            this.coffeeMakerFactory = coffeeMakerFactory;
        }
        public Coffee Prepare(CoffeeType type, CoffeeVolume volume)
        {
            var coffeeMaker = coffeeMakerFactory.CreateCoffeeMaker(type);
            var coffee = coffeeMaker.Prepare(volume);
            return coffee;
        }
    }
}

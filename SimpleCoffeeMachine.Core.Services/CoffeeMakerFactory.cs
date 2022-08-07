using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Services
{
    public class CoffeeMakerFactory: ICoffeeMakerFactory
    {
        private readonly IResourceService resourceService;

        public CoffeeMakerFactory(IResourceService resourceService)
        {
            this.resourceService = resourceService;
        }

        public ICoffeeMaker CreateCoffeeMaker(CoffeeType coffeeType)
        {
            return coffeeType switch
            {
                CoffeeType.Expresso => new ExpressoMaker(resourceService),
                CoffeeType.Americano => new AmericanoMaker(resourceService),
                CoffeeType.Flatwhite => new FlatWhiteMaker(resourceService),
                _ => throw new ArgumentException("Coffee option not available")
            };
            
        }
    }
}

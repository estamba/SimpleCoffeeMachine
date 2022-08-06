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
            if(coffeeType == CoffeeType.Expresso)
                return new ExpressoMaker(resourceService);

            if (coffeeType == CoffeeType.Flatwhite)
                return new FlatWhiteMaker(resourceService);
            throw new ArgumentException("Coffee option not available");
        }
    }
}

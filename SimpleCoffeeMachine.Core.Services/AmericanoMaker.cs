using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Services
{
    public class AmericanoMaker : ICoffeeMaker
    {
        private readonly IResourceService resourceService;

        public AmericanoMaker(IResourceService resourceService)
        {
            this.resourceService = resourceService;
        }
        public Coffee Prepare(CoffeeVolume volume)
        {
            // prepare the coffee and return it :)
            return new Americano(CoffeeType.Flatwhite, volume);
        }
    }
}

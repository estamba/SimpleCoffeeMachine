using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Services
{
    public class FlatWhiteMaker : ICoffeeMaker
    {
        public FlatWhiteMaker(IResourceService resourceService)
        {

        }
        public Coffee Prepare(CoffeeVolume volume)
        {
            // prepare the coffee and return it :)
            return new FlatWhite(CoffeeType.Flatwhite, volume);
        }
    }
}

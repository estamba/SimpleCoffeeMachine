using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;

namespace SimpleCoffeeMachine.Core.Services
{
    public class ExpressoMaker : ICoffeeMaker
    {
        private readonly IResourceService resourceService;

        public ExpressoMaker(IResourceService resourceService)
        {
            this.resourceService = resourceService;
        }
        public Coffee Prepare(double volume)
        {
            if(!resourceService.IsVailable(IngredientType.Beans, volume))
            {

            }
            var beans = resourceService.Get(IngredientType.Beans, volume);
            //some mixing of ingridients
            return new Expresso(CoffeeType.Expresso, volume);
        }
    }
}

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
        public Coffee Prepare(CoffeeVolume volume)
        {
            var ingridientVolume = 100;
            if(!resourceService.IsVailable(IngredientType.Beans, ingridientVolume))
            {

            }
            var beans = resourceService.Get(IngredientType.Beans, ingridientVolume);
            //some mixing of ingridients
            return new Expresso(CoffeeType.Expresso, volume);
        }
    }
}

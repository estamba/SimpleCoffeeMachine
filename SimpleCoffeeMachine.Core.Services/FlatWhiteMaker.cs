using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;

namespace SimpleCoffeeMachine.Core.Services
{
    public class FlatWhiteMaker : ICoffeeMaker
    {
        private readonly IResourceService resourceService;

        public FlatWhiteMaker(IResourceService resourceService)
        {
            this.resourceService = resourceService;
        }
        public Coffee Prepare(CoffeeVolume volume)
        {
            // prepare the coffee and return it :)
            return new FlatWhite(volume);
        }
    }
}

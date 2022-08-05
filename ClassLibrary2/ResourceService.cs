using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;

namespace ClassLibrary2
{
    public class ResourceService : IResourceService
    {
        public Ingredient Get(IngredientType ingredient, double volume)
        {
            // check the resource store and return results
               return new Ingredient(ingredient, volume);
        }

        public bool IsVailable(IngredientType type, double volume)
        {
            // check the resource store and return results

            return true;
        }
    }
}

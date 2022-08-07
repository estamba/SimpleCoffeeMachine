using SimpleCoffeeMachine.Core.Domain.Models;

namespace SimpleCoffeeMachine.Core.Interfaces
{
    public interface IResourceService
    {
        bool IsAvailable(IngredientType type, double volume);
        Ingredient Get(IngredientType ingredient, double volume);
    }
}

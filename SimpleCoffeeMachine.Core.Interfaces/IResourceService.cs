using SimpleCoffeeMachine.Core.Domain.Models;

namespace SimpleCoffeeMachine.Core.Interfaces
{
    public interface IResourceService
    {
        bool IsAVailable(IngredientType type, double volume);
        Ingredient Get(IngredientType ingredient, double volume);
    }
}

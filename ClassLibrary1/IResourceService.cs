using SimpleCoffeeMachine.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Interfaces
{
    public interface IResourceService
    {
        bool IsVailable(IngredientType type, double volume);
        Ingredient Get(IngredientType ingredient, double volume);
    }
}

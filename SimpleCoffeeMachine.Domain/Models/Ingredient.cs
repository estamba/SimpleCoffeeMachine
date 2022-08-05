using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Ingredient
    {
        public Ingredient(IngredientType type, double volume)
        {
            this.Type = type;
            this.Volume = volume;   
        }
        public  IngredientType Type { get; }
        public double Volume { get;}
    }
}

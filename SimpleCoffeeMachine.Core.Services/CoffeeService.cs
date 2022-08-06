using SimpleCoffeeMachine.Core.Domain.Models;
using SimpleCoffeeMachine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Services
{
    public class CoffeeService : ICoffeeService
    {
        public Coffee Prepare(CoffeeType type, CoffeeVolume volume)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCoffeeMachine.Core.Domain.Models
{
    public class Expresso : Coffee
    {
        public Expresso(CoffeeType type, CoffeeVolume volume) : base(type, volume)
        {
        }
    }
}

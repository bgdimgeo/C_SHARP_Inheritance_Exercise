﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car:Vehicle
    {
        public Car(int horsepower, double fuel) : base(horsepower, fuel)
        {
            DefaultFuelConsumption = 3;
        }
    }
}

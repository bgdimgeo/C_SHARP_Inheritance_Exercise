using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class RaceMotorcycle:Motorcycle
    {
        public RaceMotorcycle(int horsepower, double fuel) : base(horsepower, fuel)
        {
            DefaultFuelConsumption = 8;
        }

        
    }
}

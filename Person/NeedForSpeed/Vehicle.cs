using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double fuelConsumption;

        //       	•	A constructor that accepts the following parameters: int horsePower, double fuel
        //•	DefaultFuelConsumption – double 
        //•	FuelConsumption – virtual double
        //•	Fuel – double
        //•	HorsePower – int
        //•	virtual void Drive(double kilometers)

        //       o The Drive method should have a functionality to reduce the Fuel based on the traveled kilometers.
        public Vehicle(int horsepower, double fuel)
        {
            HorsePower = horsepower;
            Fuel = fuel;
        }
        public int HorsePower { get { return this.horsePower; } set { this.horsePower = value; } }
        public double Fuel { get { return this.fuel; } set { this.fuel = value; } }

        public double DefaultFuelConsumption { get { return this.fuelConsumption; } set {
                if (value > 0)
                { this.fuelConsumption = value; }
                else { this.fuelConsumption = 1.25; }
            } }

        public virtual double FuelConsumption { get { return this.fuelConsumption; } set { if (value > 0)
                { this.fuelConsumption = value; }
                else { this.fuelConsumption = DefaultFuelConsumption; }
            } }

        public virtual void Drive(double kilometers) 
        {
            Fuel -= kilometers * FuelConsumption;
        }

    }
}

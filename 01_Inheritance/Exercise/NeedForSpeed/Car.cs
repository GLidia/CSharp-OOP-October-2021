using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel) { }

        public double DefaultCarFuelConsumption = 3;

        public override double FuelConsumption => this.DefaultCarFuelConsumption;
    }
}

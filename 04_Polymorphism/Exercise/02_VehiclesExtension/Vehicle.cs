using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VehiclesExtension
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;

            if (this.FuelQuantity > this.TankCapacity)
            {
                this.FuelQuantity = 0;
            }
        }

        public abstract string Drive(double distance);
        public abstract void Refuel(double liters);
    }
}

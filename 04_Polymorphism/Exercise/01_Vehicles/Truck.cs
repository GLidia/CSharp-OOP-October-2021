using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption) { }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= (this.FuelConsumption + 1.6) * distance)
            {
                this.FuelQuantity -= (this.FuelConsumption + 1.6) * distance;
                return $"Truck travelled {distance} km";
            }
            else
            {
                return $"Truck needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += 0.95 * liters;
        }
    }
}

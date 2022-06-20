using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Vehicles
{
    public class Car : Vehicle
    {             
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption) { }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= (this.FuelConsumption + 0.9) * distance)
            {
                this.FuelQuantity -= (this.FuelConsumption + 0.9) * distance;
                return $"Car travelled {distance} km";
            }
            else
            {
                return $"Car needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}

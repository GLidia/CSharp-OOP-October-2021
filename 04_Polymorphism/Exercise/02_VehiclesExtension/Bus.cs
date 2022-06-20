using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity) { }

        public string DriveEmpty(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return $"Bus needs refueling";
            }
        }

        public override string Drive(double distance)
        {
            if (this.FuelQuantity >= (this.FuelConsumption + 1.4) * distance)
            {
                this.FuelQuantity -= (this.FuelConsumption + 1.4) * distance;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return $"Bus needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.TankCapacity < this.FuelQuantity + liters)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }
    }
}

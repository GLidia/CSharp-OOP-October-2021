using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity) { }

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

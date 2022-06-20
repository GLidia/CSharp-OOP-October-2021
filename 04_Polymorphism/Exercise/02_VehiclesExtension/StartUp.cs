using System;

namespace _02_VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            string[] truckInfo = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            string[] busInfo = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Drive" && command[1] == "Car")
                {
                    Console.WriteLine(car.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "Drive" && command[1] == "Truck")
                {
                    Console.WriteLine(truck.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "Drive" && command[1] == "Bus")
                {
                    Console.WriteLine(bus.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "DriveEmpty" && command[1] == "Bus")
                {
                    Console.WriteLine(bus.DriveEmpty(double.Parse(command[2])));
                }
                else if (command[0] == "Refuel" && command[1] == "Car")
                {
                    car.Refuel(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Truck")
                {
                    truck.Refuel(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Bus")
                {
                    bus.Refuel(double.Parse(command[2]));
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}

using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carLitersPerKm = double.Parse(carInfo[2]);

            List<string> truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);

            Car newCar = new Car(carFuelQuantity, carLitersPerKm);
            Truck newTruck = new Truck(truckFuelQuantity, truckLitersPerKm);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string cmd = commands[0];
                string vehicle = commands[1];
                double amount = double.Parse(commands[2]);

                if (cmd == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        newCar.Drive(amount);
                    }
                    else if ( vehicle == "Truck")
                    {
                        newTruck.Drive(amount);
                    }
                }
                else if (cmd == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        newCar.Refuel(amount);
                    }
                    else if (vehicle == "Truck")
                    {
                        newTruck.Refuel(amount);
                    }
                }
            }

            Console.WriteLine($"Car: {newCar.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {newTruck.FuelQuantity:F2}");
        }
    }
}
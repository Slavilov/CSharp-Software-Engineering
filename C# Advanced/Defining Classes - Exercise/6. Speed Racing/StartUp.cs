using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                List<string> infoAboutCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                
                string model = infoAboutCar[0];
                double fuelAmount = double.Parse(infoAboutCar[1]);
                double fuelConsumptionPerKm = double.Parse(infoAboutCar[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(newCar);
            }

            while (true)
            {
                List<string> listOfCommands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                
                if (listOfCommands[0] == "End")
                {
                    break;
                }

                if (listOfCommands[0] == "Drive")
                {
                    foreach (var car in cars)
                    {
                        if(car.Model == listOfCommands[1])
                        {
                            car.Drive(int.Parse(listOfCommands[2]));
                        }
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

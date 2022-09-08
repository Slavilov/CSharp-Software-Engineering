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
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                Tire[] tires = new Tire[4];

                List<string> infoAboutEachCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                string model = infoAboutEachCar[0];
                double engineSpeed = double.Parse(infoAboutEachCar[1]);
                double enginePower = double.Parse(infoAboutEachCar[2]);
                double cargoWeight = double.Parse(infoAboutEachCar[3]);
                string cargoType = infoAboutEachCar[4];
                tires[0] = new Tire(double.Parse(infoAboutEachCar[5]), int.Parse(infoAboutEachCar[6]));
                tires[1] = new Tire(double.Parse(infoAboutEachCar[7]), int.Parse(infoAboutEachCar[8]));
                tires[2] = new Tire(double.Parse(infoAboutEachCar[9]), int.Parse(infoAboutEachCar[10]));
                tires[3] = new Tire(double.Parse(infoAboutEachCar[11]), int.Parse(infoAboutEachCar[12]));

                Engine newEngine = new Engine(engineSpeed, enginePower);
                Cargo newCargo = new Cargo(cargoType, cargoWeight);

                Car newCar = new Car(model, newEngine, newCargo, tires);

                cars.Add(newCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile" && car.Tires.Any(x=>x.Pressure<1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flammable" && (car.Engine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
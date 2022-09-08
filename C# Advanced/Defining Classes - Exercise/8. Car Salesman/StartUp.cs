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
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                List<string> infoAboutEngine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (infoAboutEngine.Count == 2)
                {
                    Engine newEngine = new Engine(infoAboutEngine[0], int.Parse(infoAboutEngine[1]));
                    engines.Add(newEngine);
                }
                else if (infoAboutEngine.Count == 3)
                {
                    if (int.TryParse(infoAboutEngine[2], out int value))
                    {
                       Engine newEngine = new Engine(infoAboutEngine[0], int.Parse(infoAboutEngine[1]), int.Parse(infoAboutEngine[2]));
                       engines.Add(newEngine);
                    }
                    else
                    {
                        Engine newEngine = new Engine(infoAboutEngine[0], int.Parse(infoAboutEngine[1]), infoAboutEngine[2]);
                        engines.Add(newEngine);
                    }
                }
                else if (infoAboutEngine.Count == 4)
                {
                    Engine newEngine = new Engine(infoAboutEngine[0], int.Parse(infoAboutEngine[1]), int.Parse(infoAboutEngine[2]), infoAboutEngine[3]);
                    engines.Add(newEngine);
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                List<string> infoAboutCars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (infoAboutCars.Count == 2)
                {
                    Car newCar = new Car(infoAboutCars[0], engines.Find(x => x.Model == infoAboutCars[1]));
                    cars.Add(newCar);
                }
                else if (infoAboutCars.Count == 3)
                {
                    if (int.TryParse(infoAboutCars[2], out int value))
                    {
                        Car newCar = new Car(infoAboutCars[0], engines.Find(x => x.Model == infoAboutCars[1]), int.Parse(infoAboutCars[2]));
                        cars.Add(newCar);
                    }
                    else
                    {
                        Car newCar = new Car(infoAboutCars[0], engines.Find(x => x.Model == infoAboutCars[1]), infoAboutCars[2]);
                        cars.Add(newCar);
                    }
                }
                else if (infoAboutCars.Count == 4)
                {
                    Car newCar = new Car(infoAboutCars[0], engines.Find(x => x.Model == infoAboutCars[1]), int.Parse(infoAboutCars[2]), infoAboutCars[3]);
                    cars.Add(newCar);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine();

                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                if (car.Engine.Efficiency != "")
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != "")
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }
        }
    }
}
using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }
                else
                {
                    var newTires = new Tire[4];

                    List<string> listOfInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                    newTires[0] = new Tire(int.Parse(listOfInput[0]), double.Parse(listOfInput[1]));
                    newTires[1] = new Tire(int.Parse(listOfInput[2]), double.Parse(listOfInput[3]));
                    newTires[2] = new Tire(int.Parse(listOfInput[4]), double.Parse(listOfInput[5]));
                    newTires[3] = new Tire(int.Parse(listOfInput[6]), double.Parse(listOfInput[7]));
                    tires.Add(newTires);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }
                else
                {
                    List<string> listOfInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    int hrsPwr = int.Parse(listOfInput[0]);
                    double cubCap = double.Parse(listOfInput[1]);
                    engines.Add(new Engine(hrsPwr, cubCap));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "Show special")
                {
                    break;
                }
                else
                {
                    List<string> listOfInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                    string make = listOfInput[0];
                    string model = listOfInput[1];
                    int year = int.Parse(listOfInput[2]);
                    double fuelQnt = double.Parse(listOfInput[3]);
                    double fuelCnsmp = double.Parse(listOfInput[4]);
                    int engineIndex = int.Parse(listOfInput[5]);
                    int tiresIndex = int.Parse(listOfInput[6]);

                    cars.Add(new Car(make, model, year, fuelQnt, fuelCnsmp, engines[engineIndex], tires[tiresIndex]));
                }
                foreach (var car in cars)
                {
                    if (car.Year >= 2017 && car.Engine.HorsePower > 330 && ((car.TiresPressure(car.Tires) >= 9 && (car.TiresPressure(car.Tires) <= 10))))
                    {
                        car.Drive(20);

                        Console.WriteLine($"Make: {car.Make}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Year: {car.Year}");
                        Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                        Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                    }

                }
            }
        }
    }
}



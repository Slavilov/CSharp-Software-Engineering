using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class CatalogOfVehicles
    {
        public CatalogOfVehicles()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputCommands = new List<string>();
            string input = Console.ReadLine();

            CatalogOfVehicles catalog = new CatalogOfVehicles();

            while (input != "end")
            {
                inputCommands = input.Split('/').ToList();

                string typeOfVehicle = inputCommands[0];
                string brand = inputCommands[1];
                string model = inputCommands[2];
                string hrsOrWeight = inputCommands[3];

                if (typeOfVehicle == "Truck")
                {
                    Truck newTruck = new Truck();
                    {
                        newTruck.Brand = brand;
                        newTruck.Model = model;
                        newTruck.Weight = int.Parse(hrsOrWeight);
                    }
                    catalog.Trucks.Add(newTruck);
                }
                else
                {
                    Car newCar = new Car();
                    {
                        newCar.Brand = brand;
                        newCar.Model = model;
                        newCar.HorsePower = int.Parse(hrsOrWeight);
                    }
                    catalog.Cars.Add(newCar);
                }
                input = Console.ReadLine();
            }
            List<Truck> sortedTrucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
            List<Car> sortedCars = catalog.Cars.OrderBy(x => x.Brand).ToList();

            Console.WriteLine("Cars:");
            foreach (Car car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
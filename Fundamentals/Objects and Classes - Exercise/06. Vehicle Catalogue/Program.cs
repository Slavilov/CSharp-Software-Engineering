using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    public class Car
    {
        public Car(string typeOfVehicle, string model, string color, int horsepower)
        {
            this.TypeOfVehicle = typeOfVehicle;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {this.TypeOfVehicle}" +
                   $"Model: {this.Model}" +
                   $"Color: {this.Color}" +
                   $"Horsepower: {this.Horsepower}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<string> linesOfInput = new List<string>();
            string input = Console.ReadLine();

            int carsCounter = 0;
            int trucksCounter = 0;

            while (input != "End")
            {
                linesOfInput = input.Split(' ').ToList();

                string typeOfVehicle = linesOfInput[0];
                string model = linesOfInput[1];
                string color = linesOfInput[2];
                int horsepower = int.Parse(linesOfInput[3]);

                Car newCar = new Car(typeOfVehicle, model, color, horsepower);
                cars.Add(newCar);

                input = Console.ReadLine();
            }

            string inputVehicles = Console.ReadLine();
            while (inputVehicles != "Close the Catalogue")
            {
                if (cars.Exists(x => x.Model == inputVehicles))
                {
                    int indexOfVehicle = cars.FindIndex(x => x.Model == inputVehicles);
                    Console.WriteLine($"Type: {UppercaseFirst(cars[indexOfVehicle].TypeOfVehicle)}");
                    Console.WriteLine($"Model: {cars[indexOfVehicle].Model}");
                    Console.WriteLine($"Color: {cars[indexOfVehicle].Color}");
                    Console.WriteLine($"Horsepower: {cars[indexOfVehicle].Horsepower}");
                }

                inputVehicles = Console.ReadLine();
            }

            double averageHrsCars = 0;
            double averageHrsTrucks = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].TypeOfVehicle == "car")
                {
                    carsCounter++;
                    averageHrsCars += cars[i].Horsepower;
                }
            }
            averageHrsCars = averageHrsCars / carsCounter;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].TypeOfVehicle == "truck")
                {
                    trucksCounter++;
                    averageHrsTrucks += cars[i].Horsepower;
                }
            }
            averageHrsTrucks = averageHrsTrucks / trucksCounter;

            Console.WriteLine($"Cars have average horsepower of: {averageHrsCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHrsTrucks:f2}.");
        }

        static string UppercaseFirst(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
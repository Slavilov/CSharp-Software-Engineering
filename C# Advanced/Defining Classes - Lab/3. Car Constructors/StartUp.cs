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
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine($"FirstCar -> Make: {firstCar.Make}" +
                $"Model: {firstCar.Model}" +
                $"Year: {firstCar.Year}" +
                $"FuelQuantity: {firstCar.FuelQuantity}" +
                $"FuelConsumption: {firstCar.FuelConsumption}");
                
            Console.WriteLine($"SecondCar -> Make: {secondCar.Make}" +
                $"Model: {secondCar.Model}" +
                $"Year: {secondCar.Year}" +
                $"FuelQuantity: {secondCar.FuelQuantity}" +
                $"FuelConsumption: {secondCar.FuelConsumption}");

            Console.WriteLine($"ThirdCar -> Make: {thirdCar.Make}" +
                $"Model: {thirdCar.Model}" +
                $"Year: {thirdCar.Year}" +
                $"FuelQuantity: {thirdCar.FuelQuantity}" +
                $"FuelConsumption: {thirdCar.FuelConsumption}");
        }
    }
}

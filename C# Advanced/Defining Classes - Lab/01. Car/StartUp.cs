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
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "M3";
            car.Year = 2016;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}

using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar ferrariEnzo = new SportCar(450, 80);

            ferrariEnzo.FuelConsumption = 25;

            ferrariEnzo.Drive(250);

            Console.WriteLine(ferrariEnzo.Fuel);
        }
    }
}
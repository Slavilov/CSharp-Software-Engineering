using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            IElectricCar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat);
            seat.Start();
            seat.Stop();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(tesla);
            tesla.Start();
            tesla.Stop();

        }
    }
}
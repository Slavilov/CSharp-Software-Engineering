using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = a => a + (a * 0.20);
            List<double> prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(addVat).ToList();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}

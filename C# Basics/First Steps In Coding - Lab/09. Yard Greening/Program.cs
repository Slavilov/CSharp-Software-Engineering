using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nums1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeter = double.Parse(Console.ReadLine());
            double wholeSale = squareMeter * 7.61;
            double discount = 0.18 * wholeSale;
            double finalCost = wholeSale - discount;
            Console.WriteLine($"The final price is {finalCost} lv.");
            Console.WriteLine($"The discount is {discount} lv.");

        }
    }
}

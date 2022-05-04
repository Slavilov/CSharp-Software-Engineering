using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BasketballEquipment
{
    class Program

    {
        static void Main(string[] args)

        {
            double taxPerYear = double.Parse(Console.ReadLine());
            double sPrice = taxPerYear - taxPerYear * (40 / 100.0);
            double oPrice = sPrice - sPrice * (20 / 100.0);
            double ballPrice = oPrice / 4;
            double accsPrice = ballPrice / 5;
            double sum = taxPerYear + sPrice + oPrice + ballPrice + accsPrice;
            Console.WriteLine(sum);
        }

    }

}
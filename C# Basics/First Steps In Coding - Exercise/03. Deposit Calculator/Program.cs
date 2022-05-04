using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq zapishete sumata za depozit: ");
            double deposite = double.Parse(Console.ReadLine());

            Console.WriteLine("molq zapishete sroka na depozita v meseci: ");
            int duratation = int.Parse(Console.ReadLine());

            Console.WriteLine("Godishen lihven procent: ");
            double yield = double.Parse(Console.ReadLine());

            double sumAfterMonths = deposite + duratation * ((deposite * (yield / 100)) / 12);

            Console.WriteLine(sumAfterMonths);
        }
    }
}
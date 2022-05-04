using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FoodDelivery
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Molq vuvedete kolko pileshki meniuta shte iskate! ");
            int chickenMenu = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq vuvedete kolko ribni meniuta shte iskate! ");
            int fishMenu = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq vuvedete kolko vegetarianski meniuta s hte iskate! ");
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double vegetarianMenuPrice = vegetarianMenu * 8.15;
            double desert = (chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice) * 0.20;
            double delivery = 2.50;

            double sum = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice + desert + delivery;
            Console.WriteLine($"Vashata suma e {sum} lv!");

        }

    }

}
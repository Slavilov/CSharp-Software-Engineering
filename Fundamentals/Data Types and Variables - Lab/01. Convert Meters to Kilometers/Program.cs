﻿using System;

namespace ConvertMetersToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double km = meters * 0.001;
            Console.WriteLine($"{km:f2}");
        }
    }
}
using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _7._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOtChisla = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            CustomComparator chisla = new CustomComparator(listOtChisla);

            foreach (var item in chisla)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
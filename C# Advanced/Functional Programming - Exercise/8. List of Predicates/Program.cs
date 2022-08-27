using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SortEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            List<int> dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool flag = false;

            foreach (var number in numbers)
            {
                foreach (var divider in dividers)
                {
                    if (number % divider == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}





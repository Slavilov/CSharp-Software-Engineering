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
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            List<int> newNumbers = numbers.FindAll(x => (x % n) != 0);
            Console.Write(string.Join(' ',newNumbers));
        }
    }
}



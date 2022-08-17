using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SumNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}

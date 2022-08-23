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
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> minimumNumDelegate = minNum;
            Console.WriteLine(minimumNumDelegate(nums));
        }

        static int minNum(int[]nums)
        {
            int min = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}


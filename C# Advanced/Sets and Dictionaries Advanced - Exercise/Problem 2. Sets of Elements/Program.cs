using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = nums[0];
            int m = nums[1];

            HashSet<int> firstNums = new HashSet<int>();
            HashSet<int> secondNums = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                firstNums.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < m; j++)
            {
                secondNums.Add(int.Parse(Console.ReadLine()));
            }

             for (int i = 0; i< firstNums.Count; i++)
             {
                 if (secondNums.Contains(firstNums.ToArray()[i]))
                 {
                     Console.Write($"{firstNums.ToArray()[i]} ");
                 }
             
             }
        }
    }
}

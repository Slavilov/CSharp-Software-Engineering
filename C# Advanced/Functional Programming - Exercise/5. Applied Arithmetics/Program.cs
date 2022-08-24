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
           //Func<int, int> add = x => x + 1;
           //Func<int, int> multiply = x => x * x;
           //Func<int, int> subtract = x => x - 1;

            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string operation = Console.ReadLine();
                if (operation == "print")
                {
                    Console.WriteLine(string.Join(' ', nums));
                }
                else if (operation == "end")
                {
                    return;
                }
                else
                {
                    Calculate(nums, operation);
                }

            }

        }

        static List<int> Calculate(List<int> nums, string operation)
        {
            if (operation == "add")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i]++;
                }

            }
            else if (operation == "multiply")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] = nums[i] * 2;
                }

            }
            else if (operation == "subtract")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] = nums[i] - 1;
                }

            }
            return nums;
        }
    }
}


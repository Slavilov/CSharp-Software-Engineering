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
            string operation = Console.ReadLine();

            Predicate<int> isEven = n => n % 2 == 0;
            Predicate<int> isOdd = n => n % 2 != 0;

            List<int> numsTwo = new List<int>();

            for (int i = nums[0]; i <= nums[1]; i++)
            {
                numsTwo.Add(i);
            }
            List<int> numsThree = new List<int>();


            if (operation == "odd")
            {
               numsThree = numsTwo.FindAll(isOdd);
            }
            else
            {
                numsThree = numsTwo.FindAll(isEven);
            }

            Console.WriteLine(string.Join(' ', numsThree));
        }
    }
}

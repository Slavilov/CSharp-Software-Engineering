using System;

namespace _09_10_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumOfEven = 0;
            double sumOfOdd = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOfEven = sumOfEven + number;
                }
                if (i % 2 != 0)
                {
                    sumOfOdd = sumOfOdd + number;
                }
            }
            if (sumOfEven == sumOfOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOfOdd - sumOfEven)}");
            }
        }
    }
}

using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)Char.GetNumericValue(input[i]) < 0)
                {
                    continue;
                }
                numbers[i] = (int)Char.GetNumericValue(input[i]);
            }

            int sumOfEvens = GetSumOfEvenDigits(numbers);
            int sumOfOdds = GetSumOfOddDigits(numbers);
            int multiplied = sumOfEvens * sumOfOdds;
            Console.WriteLine(multiplied);
        }

        static int GetSumOfEvenDigits(int[] numbers)
        {
            int sumOfEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens += Math.Abs(numbers[i]);
                }
            }
            return sumOfEvens;
        }

        static int GetSumOfOddDigits(int[] numbers)
        {
            int sumOfOdds = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sumOfOdds += Math.Abs(numbers[i]);
                }
            }
            return sumOfOdds;
        }
    }
}
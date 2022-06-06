using System;

namespace SpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool correct = false;
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    correct = true;
                    Console.WriteLine($"{num} -> {correct}");
                }
                else
                {
                    correct = false;
                    Console.WriteLine($"{num} -> {correct}");
                }
            }
        }
    }
}
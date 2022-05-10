using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double maxN = 0;
            double number = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum = sum + number;

                if (number > maxN)
                {
                    maxN = number;
                }
            }
            if (maxN == (sum - maxN))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + maxN);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxN - (sum - maxN))}");
            }
        }
    }
}

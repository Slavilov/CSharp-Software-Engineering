using System;
using System.Text;
using System.Numerics;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
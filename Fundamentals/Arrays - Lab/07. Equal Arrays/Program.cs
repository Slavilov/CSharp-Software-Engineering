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
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool flag = true;
            int indexDifference = 0;
            int sumOfIdentical = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        flag = true;
                        sumOfIdentical += arrayOne[i];
                    }
                    else
                    {
                        flag = false;
                        indexDifference = i;
                        Console.WriteLine($"Arrays are not identical. Found difference at {indexDifference} index");
                        return;
                    }

                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumOfIdentical}");
        }
    }
}
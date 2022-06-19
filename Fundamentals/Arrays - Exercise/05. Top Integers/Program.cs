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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topIntegers = new int[numbers.Length];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter == ((numbers.Length) - (i + 1)))
                {
                    topIntegers[i] += numbers[i];
                }
            }
            foreach (int item in topIntegers)
            {
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
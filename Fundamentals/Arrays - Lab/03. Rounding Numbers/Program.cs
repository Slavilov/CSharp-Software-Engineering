using System;
using System.Text;
using System.Numerics;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringNumbersArray = Console.ReadLine().Split();
            double[] doubleNumbersArray = new double[stringNumbersArray.Length];

            for (int i = 0; i < stringNumbersArray.Length; i++)
            {
                doubleNumbersArray[i] = double.Parse(stringNumbersArray[i]);
            }

            for (int i = 0; i < doubleNumbersArray.Length; i++)
            {
                if (doubleNumbersArray[i] == 0)
                {
                    doubleNumbersArray[i] = 0;
                }
                Console.WriteLine($"{doubleNumbersArray[i]} => {(int)Math.Round(doubleNumbersArray[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
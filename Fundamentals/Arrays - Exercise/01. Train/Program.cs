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
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sumOfPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumOfPassengers += wagons[i];
            }

            foreach (int number in wagons)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPassengers);

        }
    }
}

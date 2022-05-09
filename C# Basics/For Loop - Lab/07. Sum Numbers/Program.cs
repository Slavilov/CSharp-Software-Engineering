using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                sum += chislo;
            }
            Console.WriteLine(sum);
        }
    }
}

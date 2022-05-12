using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int numberTwo = 0;

            while (number > sumNumbers)
            {
                numberTwo = int.Parse(Console.ReadLine());
                sumNumbers = sumNumbers + numberTwo;
            }

            Console.WriteLine(sumNumbers);
        }
    }
}

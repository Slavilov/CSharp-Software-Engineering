using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int totalAmountExtracted = 0;

            while (startingYield >= 100)
            {
                daysCounter++;
                totalAmountExtracted = (totalAmountExtracted + startingYield) - 26;
                startingYield -= 10;
            }
            totalAmountExtracted = totalAmountExtracted - 26;
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalAmountExtracted);
        }
    }
}
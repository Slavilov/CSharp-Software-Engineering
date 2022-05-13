using System;
using System.Threading;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string deposit = Console.ReadLine();
            double sum = 0;
            double add = 0;

            while (deposit != "NoMoreMoney")
            {
                add = double.Parse(deposit);

                if (add < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {add:F2}");
                sum += add;
                deposit = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}

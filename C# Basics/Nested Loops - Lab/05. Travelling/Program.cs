using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = 0;
            double savedMoneyCounter = 0;

            while (true)
            {
                string destination = Console.ReadLine();
                savedMoneyCounter = 0;

                if (destination == "End")
                {
                    return;
                }

                double minimalBudget = double.Parse(Console.ReadLine());

                while (savedMoneyCounter <= minimalBudget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    savedMoneyCounter += savedMoney;
                    if (savedMoneyCounter >= minimalBudget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }

            }
        }
    }
}

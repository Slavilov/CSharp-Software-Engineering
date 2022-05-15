using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            string action = "";
            double input = 1;
            int counter = 0;
            int counterSpend = 0;

            while (true)
            {
                action = Console.ReadLine();
                input = double.Parse(Console.ReadLine());
                counter++;

                if (action == "spend")
                {
                    availableMoney = availableMoney - input;
                    counterSpend++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else
                {
                    availableMoney = availableMoney + input;
                    counterSpend = 0;
                }

                if (availableMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    break;
                }

                if (counterSpend >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counter);
                }
            }
            if (counterSpend >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counter);
            }

        }
    }
}

using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceOfPeralnq = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double cashBday = 0;
            double stolenMoney = n * 1.00;
            double savedUpMoney = 0;
            int number = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    number = number + 1;
                    cashBday = cashBday + 10.00 * number;
                }
                else
                {
                    toys = toys + 1;
                }

            }
            double moneyFromSoldToys = toys * priceOfToy;
            savedUpMoney = moneyFromSoldToys + cashBday - (number * 1.00);

            if (savedUpMoney >= priceOfPeralnq)
            {
                Console.WriteLine($"Yes! {(savedUpMoney - priceOfPeralnq):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceOfPeralnq - savedUpMoney):f2}");
            }

        }
    }
}

using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string avioCompany = Console.ReadLine();
            int ticketsAdults = int.Parse(Console.ReadLine());
            int ticketsKids = int.Parse(Console.ReadLine());
            double priceOfTicketAdult = double.Parse(Console.ReadLine());
            double taxUsage = double.Parse(Console.ReadLine());

            double ticketsAdultsSum = ticketsAdults * (priceOfTicketAdult + taxUsage);
            double ticketsKidsSum = ticketsKids * ((priceOfTicketAdult - (priceOfTicketAdult * 0.70) + taxUsage));
            double finalSum = (ticketsAdultsSum + ticketsKidsSum) * 0.20;

            Console.WriteLine($"The profit of your agency from {avioCompany} tickets is {finalSum:f2} lv.");
        }
    }
}

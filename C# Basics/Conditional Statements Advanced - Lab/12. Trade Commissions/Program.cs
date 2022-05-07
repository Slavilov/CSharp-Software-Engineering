using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfSales = double.Parse(Console.ReadLine());
            if (volumeOfSales < 0)
            {
                Console.WriteLine("error");
                return;
            }
            double comission = 0;

            switch (city)
            {
                case "Sofia":
                    if (volumeOfSales < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    else if (volumeOfSales > 0 && volumeOfSales <= 500)
                    {
                        comission = volumeOfSales * 0.05;
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        comission = volumeOfSales * 0.07;
                    }
                    else if (volumeOfSales > 1000 && volumeOfSales < 10000)
                    {
                        comission = volumeOfSales * 0.08;
                    }
                    else if (volumeOfSales > 10000)
                    {
                        comission = volumeOfSales * 0.12;
                    }
                    Console.WriteLine($"{comission:f2}");
                    break;

                case "Varna":
                    if (volumeOfSales < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    else if (volumeOfSales > 0 && volumeOfSales <= 500)
                    {
                        comission = volumeOfSales * 0.045;
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        comission = volumeOfSales * 0.075;
                    }
                    else if (volumeOfSales > 1000 && volumeOfSales < 10000)
                    {
                        comission = volumeOfSales * 0.10;
                    }
                    else if (volumeOfSales > 10000)
                    {
                        comission = volumeOfSales * 0.13;
                    }
                    Console.WriteLine($"{comission:f2}");
                    break;

                case "Plovdiv":
                    if (volumeOfSales < 0)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    else if (volumeOfSales > 0 && volumeOfSales <= 500)
                    {
                        comission = volumeOfSales * 0.055;
                    }
                    else if (volumeOfSales > 500 && volumeOfSales <= 1000)
                    {
                        comission = volumeOfSales * 0.08;
                    }
                    else if (volumeOfSales > 1000 && volumeOfSales < 10000)
                    {
                        comission = volumeOfSales * 0.12;
                    }
                    else if (volumeOfSales > 10000)
                    {
                        comission = volumeOfSales * 0.145;
                    }
                    Console.WriteLine($"{comission:f2}");
                    break;
                default:

                    Console.WriteLine("error");
                    break;
            }
        }
    }
}

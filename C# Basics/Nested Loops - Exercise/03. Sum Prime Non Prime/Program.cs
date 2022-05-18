using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 0;
            int prostoSum = 0;
            int neProstoSum = 0;
            bool flagZaProstoChislo = true;


            while (input != "stop")
            {
                num = int.Parse(input);
                flagZaProstoChislo = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        flagZaProstoChislo = false;
                        break;
                    }
                }

                if (flagZaProstoChislo == true)
                {
                    prostoSum += num;
                }
                else
                {
                    neProstoSum += num;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prostoSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {neProstoSum}");
        }
    }
}

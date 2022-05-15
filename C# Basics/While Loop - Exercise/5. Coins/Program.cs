using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumToReturn = Math.Floor(100 * double.Parse(Console.ReadLine()));
            int counter = 0;

            while (sumToReturn > 0)
            {
                while (sumToReturn >= 200)
                {
                    sumToReturn = sumToReturn - 200;
                    counter++;
                }

                while (sumToReturn >= 100)
                {
                    sumToReturn = sumToReturn - 100;
                    counter++;
                }

                while (sumToReturn >= 50)
                {
                    sumToReturn = sumToReturn - 50;
                    counter++;
                }

                while (sumToReturn >= 20)
                {
                    sumToReturn = sumToReturn - 20;
                    counter++;
                }

                while (sumToReturn >= 10)
                {
                    sumToReturn = sumToReturn - 10;
                    counter++;
                }

                while (sumToReturn >= 5)
                {
                    sumToReturn = sumToReturn - 5;
                    counter++;
                }

                while (sumToReturn >= 2)
                {
                    sumToReturn = sumToReturn - 2;
                    counter++;
                }

                while (sumToReturn >= 1)
                {
                    sumToReturn = sumToReturn - 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

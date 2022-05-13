using System;
using System.Threading;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}

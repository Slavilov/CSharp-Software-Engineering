using System;
using System.Threading;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            int number = 0;

            while (input != "Stop")
            {
                number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(maxNumber);
        }
    }
}

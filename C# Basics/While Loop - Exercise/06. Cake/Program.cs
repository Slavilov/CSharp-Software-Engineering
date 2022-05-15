using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int lice = height * width;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{lice} pieces are left.");
                    break;
                }

                int pieceOfCakeTaken = int.Parse(input);
                lice = lice - pieceOfCakeTaken;
                if (lice <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(lice)} pieces more.");
                    break;
                }

            }
        }
    }
}

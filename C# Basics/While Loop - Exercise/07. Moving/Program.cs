using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double obem = width * lenght * height;
            double kashonSum = 0;

            while (true)
            {
                if (obem < kashonSum)
                {
                    Console.WriteLine($"No more free space! You need {kashonSum - obem} Cubic meters more.");
                    break;
                }
                string kashon = Console.ReadLine();

                if (kashon == "Done")
                {
                    if (obem > kashonSum)
                    {
                        Console.WriteLine($"{obem - kashonSum} Cubic meters left.");
                    }
                    break;
                }

                double kashonDecimal = double.Parse(kashon);
                kashonSum += kashonDecimal;

            }
        }
    }
}

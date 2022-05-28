using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            char LastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int numberSeatsOdd = int.Parse(Console.ReadLine());
            int counter = 0;

            int startSeat = 97;

            for (char i = 'A'; i <= LastSector; i++)
            {
                if (i != 'A')
                {
                    rowsFirstSector++;
                }
                for (int j = 1; j <= rowsFirstSector; j++)
                {
                    if (j % 2 != 0)
                    {
                        for (int k = 97; k <= (96 + numberSeatsOdd); k++)
                        {
                            counter++;
                            Console.WriteLine($"{i}{j}{(char)k}");
                        }
                    }
                    else
                    {
                        for (int k = 97; k <= (96 + numberSeatsOdd + 2); k++)
                        {
                            counter++;
                            Console.WriteLine($"{i}{j}{(char)k}");
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

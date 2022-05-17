using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;

            for (i = floors; i > 0; i--)
            {
                for (j = 0; j < rooms; j++)
                {
                    if (floors == 1)
                    {
                        Console.Write($"L{i}{j} ");
                        continue;
                    }
                    if (i == floors)
                    {
                        Console.Write($"L{i}{j} ");
                        continue;
                    }

                    if (i % 2.0 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

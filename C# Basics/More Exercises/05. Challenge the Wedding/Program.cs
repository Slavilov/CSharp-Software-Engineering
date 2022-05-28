using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= f; j++)
                {
                    counter++;
                    if (counter <= tables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }
    }
}

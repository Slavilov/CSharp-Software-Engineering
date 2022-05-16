using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            int k = 0;
            int counter = 0;

            for (i = 0; i <= n; i++)
            {
                if (i + j + k == n)
                {
                    counter++;
                }

                for (j = 0; j <= n; j++)
                {
                    if (i + j + k == n)
                    {
                        counter++;
                    }

                    for (k = 0; k <= n; k++)
                    {
                        if (i + j + k == n)
                        {
                            counter++;
                        }

                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

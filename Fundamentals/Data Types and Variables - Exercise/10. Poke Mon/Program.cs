using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int pokePowerOriginal = N;

            int M = int.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());

            int pokesCounter = 0;

            while (N >= M)
            {
                pokesCounter++;
                N = N - M;

                if ((decimal)N == ((decimal)(pokePowerOriginal * 0.50)))
                {
                    if (N / Y >= 0 && Y > 0)
                    {
                        N = N / Y;
                    }
                    else
                    {
                        N = N - M;
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokesCounter);
        }
    }
}
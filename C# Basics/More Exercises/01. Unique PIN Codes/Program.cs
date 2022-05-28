using System;

namespace examSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1Max = int.Parse(Console.ReadLine());
            int n2Max = int.Parse(Console.ReadLine());
            int n3Max = int.Parse(Console.ReadLine());

            for (int n1 = 2; n1 <= n1Max; n1 += 2)
            {
                for (int n2 = 2; n2 <= n2Max; n2++)
                {
                    for (int n3 = 2; n3 <= n3Max; n3 += 2)
                    {
                        if (n1 % 2 == 0 && (n2 == 2 || n2 == 3 || n2 == 5 || n2 == 7) && n3 % 2 == 0)
                        {
                            Console.WriteLine($"{n1} {n2} {n3}");
                        }
                    }
                }
            }
        }
    }
}

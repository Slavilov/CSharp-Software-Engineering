using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m > 10)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
                return;
            }
            for (m = m; m <= 10; m++)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
            }
        }
    }
}
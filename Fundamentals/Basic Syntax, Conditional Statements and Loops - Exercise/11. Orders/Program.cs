using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumForDay = 0;
            double sumForAll = 0;
            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                sumForDay = ((days * capsuleCount) * capsulePrice);
                sumForAll += sumForDay;

                Console.WriteLine($"The price for the coffee is: ${((days * capsuleCount) * capsulePrice):f2}");
                sumForDay = 0;
            }
            Console.WriteLine($"Total: ${sumForAll:f2}");
        }
    }
}
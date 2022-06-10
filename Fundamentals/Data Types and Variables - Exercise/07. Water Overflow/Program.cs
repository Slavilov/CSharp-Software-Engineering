using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;

            for (int i = 1; i <= n; i++)
            {
                int inputLeters = int.Parse(Console.ReadLine());
                if (inputLeters > 255 || (inputLeters + tank) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tank += inputLeters;
                }
            }
            Console.WriteLine(tank);
        }
    }
}
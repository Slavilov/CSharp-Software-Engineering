using System;

namespace Nums1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double farenhait = degrees * 1.8 + 32;
            Console.WriteLine("{0:f2}", farenhait);
        }
    }
}

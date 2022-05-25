using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruPrice = double.Parse(Console.ReadLine());
            int vegWeight = int.Parse(Console.ReadLine());
            int fruitWeight = int.Parse(Console.ReadLine());

            double vegPriceK = vegPrice * vegWeight;
            double fruitPriceK = fruPrice * fruitWeight;

            double sum = (vegPriceK + fruitPriceK) / 1.94;
            Console.WriteLine("{0:f2}", sum);

        }
    }
}

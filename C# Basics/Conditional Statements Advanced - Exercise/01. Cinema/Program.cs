using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (projection)
            {
                case "Premiere":
                    sum = 12.00 * (row * column);
                    break;

                case "Normal":
                    sum = 7.50 * (row * column);
                    break;

                case "Discount":
                    sum = 5.00 * (row * column);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            if (sum != 0)
            {
                Console.WriteLine($"{sum:f2} leva");
            }
        }
    }
}

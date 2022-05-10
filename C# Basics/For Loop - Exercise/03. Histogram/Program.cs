using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    counter1 = counter1 + 1;

                }
                else if (number >= 200 && number <= 399)
                {
                    counter2 = counter2 + 1;
                }
                else if (number >= 400 && number <= 599)
                {
                    counter3 = counter3 + 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    counter4 = counter4 + 1;

                }
                else if (number >= 800)
                {
                    counter5 = counter5 + 1;
                }

            }
            Console.WriteLine($"{(counter1 / n) * 100:f2}%");
            Console.WriteLine($"{(counter2 / n) * 100:f2}%");
            Console.WriteLine($"{(counter3 / n) * 100:f2}%");
            Console.WriteLine($"{(counter4 / n) * 100:f2}%");
            Console.WriteLine($"{(counter5 / n) * 100:f2}%");

        }
    }
}

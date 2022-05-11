using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string tabName = "";
            int fine = 0;

            for (int i = 0; i < n; i++)
            {
                tabName = Console.ReadLine();

                switch (tabName)
                {
                    case "Facebook":
                        fine = fine + 150;
                        break;

                    case "Instagram":
                        fine = fine + 100;

                        break;

                    case "Reddit":
                        fine = fine + 50;
                        break;
                }
                if (salary <= fine)
                {
                    Console.WriteLine("You have lost your salary.");
                    i = n;
                }
            }
            if (salary > fine)
            {
                Console.WriteLine($"{salary - fine}");
            }

        }
    }
}

using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double sumOfAll = 0;
            //double lightSabers10 = priceOfSaber * (student + Math.Ceiling(student * 0.10));
            double beltDiscount = priceOfBelt * (student / 6);

            sumOfAll = ((priceOfSaber * (student + Math.Ceiling(student * 0.10)) + (priceOfRobe * student) + ((priceOfBelt * student) - beltDiscount)));

            if (sumOfAll <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sumOfAll:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(sumOfAll - money):f2}lv more.");
            }
        }
    }
}
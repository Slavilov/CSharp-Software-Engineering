using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                Console.WriteLine("Molq vuvedete stranata na kvadrata: ");
                double side = double.Parse(Console.ReadLine());
                double area = (side * side);
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                Console.WriteLine("Molq vuvedete dvete strani na pravougulnika:");
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaR = sideA * sideB;
                Console.WriteLine($"{areaR:F3}");
            }
            else if (figure == "circle")
            {
                Console.WriteLine("Molq vuvedete radiusa na kruga: ");
                double radius = double.Parse(Console.ReadLine());
                double areaC = Math.PI * radius * radius;
                Console.WriteLine($"{areaC:F3}");
            }
            else if (figure == "triangle")
            {
                Console.WriteLine("Molq vuvedete duljinata i visochinata na triugulnika: ");
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double areaT = (lenght * width) / 2.0;
                Console.WriteLine($"{areaT:F3}");
            }
        }
    }
}


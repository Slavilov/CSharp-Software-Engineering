using System;

namespace Conditions.GradeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberone = int.Parse(Console.ReadLine());
            int numbertwo = int.Parse(Console.ReadLine());
            if (numberone > numbertwo)
            {
                Console.WriteLine(numberone);
            }
            else
            {
                Console.WriteLine(numbertwo);
            }
        }
    }
}

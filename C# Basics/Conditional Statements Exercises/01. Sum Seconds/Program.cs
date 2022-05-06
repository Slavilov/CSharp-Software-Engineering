using System;

namespace Conditions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());
            int sum = firstTime + SecondTime + ThirdTime;
            double one = sum / 60;
            double two = sum % 60;
            if (two < 10)
            {
                Console.WriteLine($"{one}:0{two}");
            }
            else
            {
                Console.WriteLine($"{one}:{two}");
            }
        }
    }
}

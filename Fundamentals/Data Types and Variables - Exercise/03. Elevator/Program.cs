using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPpl = int.Parse(Console.ReadLine());
            int maxCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numOfPpl / maxCapacity);
            Console.WriteLine(courses);
        }
    }
}
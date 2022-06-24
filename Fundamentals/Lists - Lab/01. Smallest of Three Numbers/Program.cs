using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestOfThreeNums(numOne, numTwo, numThree));
        }

        static int SmallestOfThreeNums(int numOne, int numTwo, int numThree)
        {
            if (numOne < numTwo && numOne < numThree)
            {
                return numOne;
            }
            else if (numTwo < numOne && numTwo < numThree)
            {
                return numTwo;
            }
            else
            {
                return numThree;
            }
        }
    }
}
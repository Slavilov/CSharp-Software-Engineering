using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sumOne = firstNum + secondNum;

            int thirdNum = int.Parse(Console.ReadLine());
            int sumTwo = sumOne / thirdNum;


            int fourthNum = int.Parse(Console.ReadLine());
            int sumThree = sumTwo * fourthNum;

            Console.WriteLine(sumThree);
        }
    }
}
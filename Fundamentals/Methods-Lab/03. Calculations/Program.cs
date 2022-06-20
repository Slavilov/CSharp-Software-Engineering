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
            string input = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (input == "add")
            {
                add(firstNumber, secondNumber);
            }
            else if (input == "multiply")
            {
                multiply(firstNumber, secondNumber);
            }
            else if (input == "substract")
            {
                substract(firstNumber, secondNumber);
            }
            else
            {
                divide(firstNumber, secondNumber);
            }
        }


        static void add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }

        static void multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        static void substract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        static void divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
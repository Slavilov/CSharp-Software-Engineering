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
            if (input == "int")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (input == "char")
            {
                char symb1 = char.Parse(Console.ReadLine());
                char symb2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(symb1, symb2));
            }
            else if (input == "string")
            {
                string letter1 = Console.ReadLine();
                string letter2 = Console.ReadLine();
                Console.WriteLine(GetMax(letter1, letter2));
            }
        }

        static double GetMax(double num1, double num2)
        {
            double maxNum = 0;

            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            return maxNum;
        }

        static char GetMax(char symb1, char symb2)
        {
            //char max = String.Empty;
            if ((int)symb1 > (int)symb2)
            {
                return symb1;
            }
            else
            {
                return symb2;
            }
        }

        static string GetMax(string letter1, string letter2)
        {
            //string max = string.Empty;
            //
            //int sum1 = 0;
            //int sum2 = 0;
            //
            //for (int i = 0; i < letter1.Length; i++)
            //{
            //    sum1 += (int)letter1[i];
            //}
            //
            //for (int j = 0; j < letter2.Length; j++)
            //{
            //    sum2 += (int)letter2[j];
            //}

            if (letter1.CompareTo(letter2) > 0)
            {
                return letter1;
            }
            else
            {
                return letter2;
            }
        }
    }
}
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
            int n = int.Parse(Console.ReadLine());
            int numberOne = 0;
            int numberTwo = 0;
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
            int counterNumOne = 1;
            for (int i = 0; i < n; i++)
            {
                counterNumOne++;
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                numberOne = input[0];
                numberTwo = input[1];
                if (counterNumOne % 2 == 0)
                {
                    arrayOne[i] = numberOne;
                    arrayTwo[i] = numberTwo;
                }
                else
                {
                    arrayOne[i] = numberTwo;
                    arrayTwo[i] = numberOne;
                }

            }
            Console.WriteLine(String.Join(' ', arrayOne));
            Console.WriteLine(String.Join(' ', arrayTwo));

        }
    }
}
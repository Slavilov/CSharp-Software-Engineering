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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumToLeft = 0;
            int sumToRight = 0;
            bool flag = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0)
                {
                    sumToLeft += numbers[i - 1];
                }
                if (i == numbers.Length - 1)
                {
                    sumToRight = 0;

                    if (sumToRight == sumToLeft)
                    {
                        Console.WriteLine(i);
                        flag = true;
                        break;
                    }
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (i == 0)
                    {
                        sumToLeft = 0;
                    }
                    if (i == numbers.Length - 1)
                    {
                        sumToRight = 0;
                    }
                    sumToRight += numbers[j];

                    if (sumToRight == sumToLeft)
                    {
                        Console.Write(i + " ");
                        flag = true;
                        break;
                    }

                }
                //if (flag == true)
                //{
                //    break;
                //}
                sumToRight = 0;

            }
            Console.WriteLine();
            if (flag == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}
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
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();
            string[] commonElements = new string[arrayOne.Length];

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    if (arrayTwo[i] == arrayOne[j])
                    {
                        commonElements[i] = arrayTwo[i];
                    }
                }
            }
            foreach (string element in commonElements)
            {
                if (element != null)
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
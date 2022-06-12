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
            string[] array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[array.Length - 1 - i];

                array[array.Length - 1 - i] = array[i];
                array[i] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
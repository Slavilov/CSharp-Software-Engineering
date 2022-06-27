using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace PasswordCheckUp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombPower[0])
                {
                    if (i + bombPower[1] > numbers.Count - 1)
                    {
                        numbers.RemoveRange((i - bombPower[1]), (1 + ((2 * bombPower[1])) - (numbers.Count - i)));
                        i = 0;
                    }
                    else if (i - bombPower[1] < 0)
                    {
                        numbers.RemoveRange(0, (1 + (2 * bombPower[1]) - (i - 1)));
                        i = 0;
                    }
                    else
                    {
                        numbers.RemoveRange((i - bombPower[1]), (1 + (2 * bombPower[1])));
                        i = 0;
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
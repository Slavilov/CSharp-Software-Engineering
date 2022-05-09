using System;

namespace NumbersNto
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = int.Parse(Console.ReadLine()); number > 0; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}

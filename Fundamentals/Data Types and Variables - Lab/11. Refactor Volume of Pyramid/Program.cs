using System;
using System.Text;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, heigth, length, V = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            V = 1 / 3.0 * (length * width) * heigth;
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
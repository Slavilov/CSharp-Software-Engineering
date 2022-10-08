using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Shapes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            circle.Draw();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(40, 15);
            rectangle.Draw();
        }
    }
}
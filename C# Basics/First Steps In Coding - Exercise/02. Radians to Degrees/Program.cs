using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RadiansToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degrees = radian * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
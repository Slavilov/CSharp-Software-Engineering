using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UsdtoBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double USDtoBGN = USD * 1.79549;
            Console.WriteLine(USDtoBGN);
        }
    }
}

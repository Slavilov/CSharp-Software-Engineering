using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq zapishete razmerite na akvariuma!");
            Console.WriteLine("Molq zapishete negovata duljina!");
            int lenghth = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete negovata shirina!");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete negovata visochina!");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete % ot akvariuma koqto shte e zaeta ot rasteniq i pqsuk");
            double areaFull = double.Parse(Console.ReadLine());

            double volumeOfAquarium = lenghth * width * height;
            double volumeWater = volumeOfAquarium / 1000;
            double areFullPrcntg = areaFull / 100;
            double volumeNeeded = volumeWater * (1 - areFullPrcntg);
            Console.WriteLine($"Nujnite litri voda sa: {volumeNeeded} ");


        }
    }
}
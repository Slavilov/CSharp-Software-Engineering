using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vuvedete kolko nailon shte polzvate: ");
            int nilon = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq vuvedete kolko litra boq shte polzvate: ");
            int paint = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq vuvedete kolko litra razreditel shte polzvate: ");
            int thinner = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq vuvedete za kolko chasa shte se svurshi rabotata: ");
            int time = int.Parse(Console.ReadLine());

            double morePaint = paint * 0.10;
            int moreNilon = 2;

            double bags = 0.40;
            double nilonPrice = nilon * 1.50;
            double paintPrice = paint * 14.50;
            double thinnerPrice = thinner * 5.00;
            double morePaintPrice = morePaint * 14.50;
            double moreNilonPrice = moreNilon * 1.50;
            double jobPayPerHr = (nilonPrice + paintPrice + thinnerPrice + bags + morePaintPrice + moreNilonPrice) * 0.30;
            double workersPay = time * jobPayPerHr;
            double finalPriceOfAll = bags + nilonPrice + paintPrice + thinnerPrice + morePaintPrice + moreNilonPrice + workersPay;
            Console.WriteLine(finalPriceOfAll);

        }
    }
}

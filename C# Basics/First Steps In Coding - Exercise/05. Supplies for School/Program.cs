using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq zapishete kolko paketa himikali shte zakupite: ");
            int packsOfPencils = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete kolko paketa markeri shte zakupite: ");
            int packsOfMarkers = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete kolko litra preparat za duska shte zakupite: ");
            int soap = int.Parse(Console.ReadLine());

            Console.WriteLine("Kakuv procent namalenie poluchamae: ");
            int percentage = int.Parse(Console.ReadLine());

            double sumpacksOfPencils = packsOfPencils * 5.80;
            double sumpacksOfMarkers = packsOfMarkers * 7.20;
            double sumOfSoap = soap * 1.20;

            double sumOfAll = sumpacksOfPencils + sumpacksOfMarkers + sumOfSoap;
            double prcntg = percentage / 100;

            double sumOfAllWithDiscount = sumOfAll - sumOfAll * (percentage / 100.0);

            Console.WriteLine($"Shte sa ni nujni {sumOfAllWithDiscount} lv. za da platim smetkata");

        }
    }
}
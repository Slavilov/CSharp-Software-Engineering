using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(Math.Abs(dateModifier.DifferenceBetweenTwoDates(firstDate, secondDate)));

            LinkedList<int> linkiranlist = new LinkedList<int>();
        }
    }
}
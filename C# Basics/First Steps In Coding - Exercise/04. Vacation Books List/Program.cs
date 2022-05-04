using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace VacationBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq zapishete broqt stranici: ");
            int allPagesOfTheBooks = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete broqt stranici na chas");
            int pagesPerHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Molq zapishete dnite za koito trqbva da se pochetat knigite: ");
            int daysToRead = int.Parse(Console.ReadLine());

            double pagesPerDay = (allPagesOfTheBooks / pagesPerHour) / daysToRead;

            Console.WriteLine(pagesPerDay);

        }
    }
}

using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList nekuvList = new RandomList();
            nekuvList.Add("ivanka");
            nekuvList.Add("draganka");
            nekuvList.Add("petkanka");
            nekuvList.Add("ivancho");
            nekuvList.Add("dragancho");
            nekuvList.Add("petkancho");

            Console.WriteLine($"Elements in the list before removing elements {nekuvList.Count}");
            nekuvList.RemoveRandomElement();
            Console.WriteLine($"Elements left in the list {nekuvList.Count}");
            Console.WriteLine();

            Console.WriteLine($"Now giving random element:");
            Console.WriteLine(nekuvList.RandomString());
        }
    }
}
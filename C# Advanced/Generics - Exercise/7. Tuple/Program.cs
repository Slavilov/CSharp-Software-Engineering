using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TupleExercise
{
    class StartUp
    {
        static void Main(string[] args)
        {

            List<string> firstInput = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
            string name = $"{firstInput[0]} {firstInput[1]}";
            CustomTuple<string, string> stringTuple = new CustomTuple<string, string>(name, firstInput[2]);


            List<string> secondInput = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
            CustomTuple<string, int> stringAndintTuple = new CustomTuple<string, int>(secondInput[0], int.Parse(secondInput[1]));


            List<string> thirdInput = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();
            CustomTuple<int, double> intAndDoubleTuple = new CustomTuple<int, double> (int.Parse(thirdInput[0]), double.Parse(thirdInput[1]));



            Console.WriteLine($"{stringTuple.FirstElement} -> {stringTuple.SecondElement}");
            Console.WriteLine($"{stringAndintTuple.FirstElement} -> {stringAndintTuple.SecondElement}");
            Console.WriteLine($"{intAndDoubleTuple.FirstElement} -> {intAndDoubleTuple.SecondElement}");
        }
    }
}
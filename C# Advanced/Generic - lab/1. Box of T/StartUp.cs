using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> tupak = new Box<int>();
            tupak.Add(69);
            tupak.Add(6969);
            tupak.Add(666);
            
            Console.WriteLine(tupak.Remove());

            tupak.Add(33);
            tupak.Add(363363);

            Console.WriteLine(tupak.Remove());
        }
    }
}

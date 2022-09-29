using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Child peter = new Child("Peter", 17);

            Console.WriteLine(peter);
        }
    }
}
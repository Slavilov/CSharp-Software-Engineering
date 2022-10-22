﻿using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;


namespace Animals

{
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
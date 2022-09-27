using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy sharko = new Puppy();
            sharko.Eat();
            sharko.Bark();
            sharko.Weep();
        }
    }
}
using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectsName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timeToFinish = numberOfProjects * 3;
            Console.WriteLine($"The architect {architectsName} will need {timeToFinish} hours to complete {numberOfProjects} project/s.");

        }
    }
}

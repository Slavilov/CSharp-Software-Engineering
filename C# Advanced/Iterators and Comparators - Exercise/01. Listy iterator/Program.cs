using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Iterators_and_Comparators_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().Skip(1).ToList();

            ListyIterator<string> customCollection = new ListyIterator<string>(elements);

            try
            {
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Move")
                    {
                        customCollection.Move();
                    }
                    else if (command == "HasNext")
                    {
                        customCollection.HasNext();
                    }
                    else if (command == "Print")
                    {
                        customCollection.Print();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
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
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).Skip(1).ToList();

            ListyIterator<int> customCollection = new ListyIterator<int>(elements);

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
                    else if (command == "PrintAll")
                    {
                        foreach (var item in customCollection)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
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
using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string kids = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] arrayOfKids = kids.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queOfKids = new Queue<string>();
            int counter = 0;

            for (int i = 0; i < arrayOfKids.Length; i++)
            {
                queOfKids.Enqueue(arrayOfKids[i]);
            }


            while (queOfKids.Count > 1)
            {
                counter++;
                string temporaryKids = queOfKids.Dequeue();

                if (counter % n == 0)
                {
                    Console.WriteLine($"Removed {temporaryKids}");
                    continue;
                }

                queOfKids.Enqueue(temporaryKids);
            }
            Console.WriteLine($"Last is {queOfKids.Last()}");
        }
    }
}
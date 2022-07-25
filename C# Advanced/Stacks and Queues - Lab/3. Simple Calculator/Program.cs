using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsThatCanPass = int.Parse(Console.ReadLine());
            Queue<string> queOfCars = new Queue<string>();
            int counter = 0;

            while(true)
            {
                string command = Console.ReadLine();
                
                if (command == "end")
                {
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i<carsThatCanPass;i++)
                    {
                        if (queOfCars.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{queOfCars.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    queOfCars.Enqueue(command);
                }
            }
        }
    }
}

using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfPpl = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < numOfPpl; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input.Count == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    Citizens newCitizen = new Citizens(name, age, id, birthdate);
                    buyers.Add(newCitizen);
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    Rebel newRebel = new Rebel(name, age, group);
                    buyers.Add(newRebel);
                }
            }

            while (true)
            {
                string namesOrEnd = Console.ReadLine();

                if (namesOrEnd == "End")
                {
                    break;
                }

                foreach (var buyer in buyers)
                {
                    if (buyer.Name == namesOrEnd)
                    {
                        buyer.BuyFood();
                    }
                }
            }

            Console.WriteLine(buyers.Sum(x=>x.Food));
        }
    }
}
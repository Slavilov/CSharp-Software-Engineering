using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BaristaContest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> quantityOfCoffee = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> quantityOfMilk = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> coffee = new Queue<int>();
            Stack<int> milk = new Stack<int>();

            Dictionary<string, int> typesOfCoffees = new Dictionary<string, int>();
            typesOfCoffees.Add("Cortado", 0);
            typesOfCoffees.Add("Espresso", 0);
            typesOfCoffees.Add("Capuccino", 0);
            typesOfCoffees.Add("Americano", 0);
            typesOfCoffees.Add("Latte", 0);

            foreach (var cofe in quantityOfCoffee)
            {
                coffee.Enqueue(cofe);
            }
            foreach (var leche in quantityOfMilk)
            {
                milk.Push(leche);
            }

            while (coffee.Count > 0 && milk.Count > 0)
            {
                int currentCoffee = coffee.Peek();
                int currentMilk = milk.Peek();

                if ((currentCoffee + currentMilk) == 50 ||
                    (currentCoffee + currentMilk) == 75 ||
                    (currentCoffee + currentMilk) == 100 ||
                    (currentCoffee + currentMilk) == 150 ||
                    (currentCoffee + currentMilk) == 200)
                {
                    coffee.Dequeue();
                    milk.Pop();

                    if (currentCoffee + currentMilk == 50)
                    {
                        typesOfCoffees["Cortado"]++;
                    }
                    else if (currentCoffee + currentMilk == 75)
                    {
                        typesOfCoffees["Espresso"]++;
                    }
                    else if (currentCoffee + currentMilk == 100)
                    {
                        typesOfCoffees["Capuccino"]++;
                    }
                    else if (currentCoffee + currentMilk == 150)
                    {
                        typesOfCoffees["Americano"]++;
                    }
                    else if (currentCoffee + currentMilk == 200)
                    {
                        typesOfCoffees["Latte"]++;
                    }
                }
                else
                {
                    coffee.Dequeue();
                    milk.Pop();

                    currentMilk = currentMilk - 5;
                    milk.Push(currentMilk);
                }
            }

            if (coffee.Count == 0 && milk.Count == 0)
            {
                Console.WriteLine($"Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine($"Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            if (coffee.Count == 0)
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.WriteLine($"Coffee left: " + string.Join(", ", coffee));
            }

            if (milk.Count == 0)
            {
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine($"Milk left: " + string.Join(", ", milk));
            }

            foreach (var cofe in typesOfCoffees.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (cofe.Value == 0)
                {
                    continue;
                }
                Console.WriteLine($"{cofe.Key}: {cofe.Value}");
            }
        }
    }
}
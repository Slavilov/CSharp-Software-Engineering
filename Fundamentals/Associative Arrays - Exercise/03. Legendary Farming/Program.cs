using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> listOfAllMaterials = new SortedDictionary<string, int>();
            listOfAllMaterials.Add("shards", 0);
            listOfAllMaterials.Add("motes", 0);
            listOfAllMaterials.Add("fragments", 0);
            List<string> inputOfMaterials = new List<string>();

            //Dictionary<string, int> listOfGoodMaterials = new Dictionary<string, int>();
            //Dictionary<string, int> listOfJunkMaterials = new Dictionary<string, int>();

            bool flagForStop = false;
            string winningItem = string.Empty;
            int winningItemQuantity = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                inputOfMaterials = input.Split(' ').ToList();
                inputOfMaterials.Reverse();

                for (int i = 0; i < inputOfMaterials.Count; i += 2)
                {
                    if (listOfAllMaterials.ContainsKey(inputOfMaterials[i].ToLower()))
                    {
                        listOfAllMaterials[inputOfMaterials[i]] += int.Parse(inputOfMaterials[i + 1]);
                    }
                    else
                    {
                        listOfAllMaterials.Add(inputOfMaterials[i].ToLower(), int.Parse(inputOfMaterials[i + 1]));
                    }
                }

                foreach (var item in listOfAllMaterials)
                {
                    if (item.Value >= 250)
                    {
                        flagForStop = true;
                        winningItem = item.Key;
                        winningItemQuantity = item.Value;
                        break;
                    }
                }

                if (flagForStop == true)
                {
                    break;
                }

            }


            if (winningItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (winningItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var item in listOfAllMaterials)
            {
                if (item.Key == "shards" || (item.Key == "fragments") || (item.Key == "motes"))
                {
                    if (item.Key == winningItem)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value - 250}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            }

            foreach (var item in listOfAllMaterials)
            {
                if (item.Key != "shards" && (item.Key != "fragments") && (item.Key != "motes"))
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
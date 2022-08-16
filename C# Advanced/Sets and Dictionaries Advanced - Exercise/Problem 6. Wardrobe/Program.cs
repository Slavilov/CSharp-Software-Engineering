using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string clothes = Console.ReadLine();
                List<string> listOfClothes = clothes.Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string colour = listOfClothes[0];

                if (wardrobe.ContainsKey(colour))
                {
                    for (int j = 1; j < listOfClothes.Count; j++)
                    {
                        if (wardrobe[colour].ContainsKey(listOfClothes[j]))
                        {
                            wardrobe[colour][listOfClothes[j]]++;
                        }
                        else
                        {
                            wardrobe[colour].Add(listOfClothes[j], 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                    for (int j = 1; j < listOfClothes.Count; j++)
                    {
                        if (wardrobe[colour].ContainsKey(listOfClothes[j]))
                        {
                            wardrobe[colour][listOfClothes[j]]++;
                        }
                        else
                        {
                           wardrobe[colour].Add(listOfClothes[j], 1);
                        }
                    }
                }
            }

            List<string> toSearchFor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string colourToSearch = toSearchFor[0];
            string clothingToSearch = toSearchFor[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothe in item.Value)
                {
                    if (item.Key == colourToSearch && clothe.Key == clothingToSearch)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                       Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}



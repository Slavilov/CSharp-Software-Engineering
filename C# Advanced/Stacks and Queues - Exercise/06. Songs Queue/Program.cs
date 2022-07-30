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
            Queue<string> queOfSongs = new Queue<string>();
            string songs = Console.ReadLine();
            List<string> listOfSongs = songs.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < listOfSongs.Count; i++)
            {
                queOfSongs.Enqueue(listOfSongs[i]);
            }

            while (queOfSongs.Count > 0)
            {
                string commands = Console.ReadLine();

                if (commands.Contains("Play"))
                {
                    queOfSongs.Dequeue();
                }
                else if (commands.Contains("Add"))
                {
                    string songName = commands.Substring(4, commands.Length - 4);

                    if (queOfSongs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        queOfSongs.Enqueue(songName);
                    }
                }
                else if (commands.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queOfSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
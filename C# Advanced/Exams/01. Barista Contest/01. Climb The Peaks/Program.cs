using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BaristaContest
{
    class Peak
    {
        public Peak(string name, int difficulty)
        {
            this.Name = name;
            this.Difficulty = difficulty;
        }

        public string Name { get; set; }
        public int Difficulty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> quantityOfDailyPortion = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> quantityOfDailyStamina = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<Peak> peakList = new List<Peak>();
            Peak vihren = new Peak("Vihren", 80);
            Peak kutelo = new Peak("Kutelo", 90);
            Peak banskiSuhodol = new Peak("Banski Suhodol", 100);
            Peak polezhan = new Peak("Polezhan", 60);
            Peak kamenitza = new Peak("Kamenitza", 70);

            List<Peak> conqueredPeaks = new List<Peak>();

            peakList.Add(vihren);
            peakList.Add(kutelo);
            peakList.Add(banskiSuhodol);
            peakList.Add(polezhan);
            peakList.Add(kamenitza);

            Stack<int> dailyFoodPortion = new Stack<int>();
            Queue<int> dailyStamina = new Queue<int>();

            int successfullConqueredAttempts = 0;
            int sumOfFoodAndStamina = 0;

            for (int i = 0; i < 7; i++)
            {
                dailyFoodPortion.Push(quantityOfDailyPortion[i]);
                dailyStamina.Enqueue(quantityOfDailyStamina[i]);
            }

            while (dailyFoodPortion.Count > 0 && dailyStamina.Count > 0 && peakList.Count > 0)
            {
                if ((dailyFoodPortion.Peek() + dailyStamina.Peek()) >= peakList[0].Difficulty)
                {
                    conqueredPeaks.Add(peakList[0]);
                    peakList.RemoveAt(0);
                    successfullConqueredAttempts++;
                    dailyFoodPortion.Pop();
                    dailyStamina.Dequeue();
                }
                else
                {
                    dailyFoodPortion.Pop();
                    dailyStamina.Dequeue();
                }
            }

            if (peakList.Count == 0)
            {
                Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else if (peakList.Count > 0)
            {
                Console.WriteLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (conqueredPeaks.Count > 0)
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var peak in conqueredPeaks)
                {
                    Console.WriteLine($"{peak.Name}");
                }
            }
        }
    }
}
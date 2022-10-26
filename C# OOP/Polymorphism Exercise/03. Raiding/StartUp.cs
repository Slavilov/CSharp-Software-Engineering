using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Raiding
{
     class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int characters = 0;
            List<BaseHero> listOfHeroes = new List<BaseHero>();

            while (characters < n)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid" ||
                    heroType == "Paladin" ||
                    heroType == "Rogue" ||
                    heroType == "Warrior")
                {
                    BaseHero newHero = CharacterFactory.getHero(heroName, heroType);
                    listOfHeroes.Add(newHero);
                    characters++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }
            int bossPower = int.Parse(Console.ReadLine());
            
            foreach (var hero in listOfHeroes)
            {
                hero.CastAbility();
            }

            if (listOfHeroes.Select(x=>x.Power).Sum() >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
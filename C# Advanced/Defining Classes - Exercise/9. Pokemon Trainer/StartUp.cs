using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                List<string> infoAboutPokemonAndTrainer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                
                if (infoAboutPokemonAndTrainer[0] == "Tournament")
                {
                    break;
                }

                string trainerName = infoAboutPokemonAndTrainer[0];
                string pokemonName = infoAboutPokemonAndTrainer[1];
                string pokemonElement = infoAboutPokemonAndTrainer[2];
                double pokemonHealth = double.Parse(infoAboutPokemonAndTrainer[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Any(x=>x.Name == trainerName))
                {
                    trainers.Find(x => x.Name == trainerName).addPokemon(newPokemon);
                }
                else
                {
                   Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.addPokemon(newPokemon);
                    trainers.Add(newTrainer);
                }
            }

            while (true)
            {
                string elements = Console.ReadLine();
                
                if (elements == "End")
                {
                    break;
                }

                bool flag = false;

                foreach (var trainer in trainers)
                {
                    foreach (var pokemon in trainer.Pokemons )
                    {
                        if (pokemon.Element == elements)
                        {
                            trainer.addBadge(1);
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;

                            if (trainer.Pokemons.Count >0)
                            {
                               trainer.checkPokemonHealth();
                            }
                            if (trainer.Pokemons.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                    flag = false;
                }
            }
            trainers = trainers.OrderByDescending(x => x.Badges).ToList();

            foreach (var trainerInfo in trainers)
            {
                Console.WriteLine($"{trainerInfo.Name} {trainerInfo.Badges} {trainerInfo.Pokemons.Count}");
            }
        }
    }
}
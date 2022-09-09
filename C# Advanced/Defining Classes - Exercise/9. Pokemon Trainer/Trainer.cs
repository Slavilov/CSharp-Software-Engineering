using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Trainer
    {
        public Trainer(string name)
        {
            this.name = name;
        }

        private string name;
        private int badges = 0;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }



        public void addPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void addBadge(int badge)
        {
            this.Badges += badge;
        }

        public void checkPokemonHealth()
        {
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Health <= 0)
                {
                    pokemons.Remove(pokemon);
                }
                if (pokemons.Count == 0)
                {
                    break;
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string pokemonName, string pokemonElement, double pokemonHelth)
        {
            PokemonName = pokemonName;
            PokemonElement = pokemonElement;
            PokemonHealth = pokemonHelth;
        }

        public string PokemonName { get; set; }
        public string PokemonElement { get; set; }
        public double PokemonHealth { get; set; }

    }
}

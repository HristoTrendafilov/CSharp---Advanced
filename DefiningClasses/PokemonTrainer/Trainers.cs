using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainers
    {
        public Trainers(string trainerName, int numberOfBadges, int collectionPokemons, List<Pokemon> pokemons)
        {
            TrainerName = trainerName;
            NumberOfBadges = numberOfBadges;
            CollectionPokemons = collectionPokemons;
            Pokemons = pokemons;
        }

        public string TrainerName { get; set; }
        public int NumberOfBadges { get; set; } 
        public int CollectionPokemons { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}

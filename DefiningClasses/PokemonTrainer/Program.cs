using System;
using System.Linq;
using System.Collections.Generic;
namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainersAndPokemons = new List<Trainers>();
            while (true)
            {
                var command = Console.ReadLine().Split();
                if(command[0]== "Tournament")
                {
                    break;
                }
                var trainerName = command[0];
                var pokemonName= command[1];
                var pokemonElement = command[2];
                var pokemonHealth = double.Parse(command[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (trainersAndPokemons.Any(x => x.TrainerName == trainerName))
                {
                    foreach (var trainer1 in trainersAndPokemons)
                    {
                        if (trainer1.TrainerName == trainerName)
                        {
                            trainer1.Pokemons.Add(pokemon);
                        }
                    }
                }
                else
                {
                    var trainer = new Trainers(trainerName, 0, 0, new List<Pokemon>());
                    trainer.Pokemons.Add(pokemon);
                    trainersAndPokemons.Add(trainer);
                }
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (command == "Fire")
                {
                    for (int i = 0; i < trainersAndPokemons.Count; i++)
                    {
                        if (trainersAndPokemons[i].Pokemons.Any(x => x.PokemonElement == "Fire"))
                        {
                            trainersAndPokemons[i].NumberOfBadges++;
                        }
                        else
                        {
                            for (int k = 0; k < trainersAndPokemons[i].Pokemons.Count; k++)
                            {
                                if (trainersAndPokemons[i].Pokemons[k].PokemonElement != "Fire")
                                {
                                    trainersAndPokemons[i].Pokemons[k].PokemonHealth -= 10;
                                    if (trainersAndPokemons[i].Pokemons[k].PokemonHealth <= 0)
                                    {
                                        trainersAndPokemons[i].Pokemons.Remove(trainersAndPokemons[i].Pokemons[k]);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (command == "Water")
                {
                    for (int i = 0; i < trainersAndPokemons.Count; i++)
                    {
                        if (trainersAndPokemons[i].Pokemons.Any(x => x.PokemonElement == "Water"))
                        {
                            trainersAndPokemons[i].NumberOfBadges++;
                        }
                        else
                        {
                            for (int k = 0; k < trainersAndPokemons[i].Pokemons.Count; k++)
                            {
                                if (trainersAndPokemons[i].Pokemons[k].PokemonElement!="Water")
                                {
                                    trainersAndPokemons[i].Pokemons[k].PokemonHealth -= 10;
                                    if (trainersAndPokemons[i].Pokemons[k].PokemonHealth <= 0)
                                    {
                                        trainersAndPokemons[i].Pokemons.Remove(trainersAndPokemons[i].Pokemons[k]);
                                    }
                                }
                            }
                        }
                    }
                }
               else if (command == "Electricity")
                {
                    for (int i = 0; i < trainersAndPokemons.Count; i++)
                    {
                        if (trainersAndPokemons[i].Pokemons.Any(x => x.PokemonElement == "Electricity"))
                        {
                            trainersAndPokemons[i].NumberOfBadges++;
                        }
                        else
                        {
                            for (int k = 0; k < trainersAndPokemons[i].Pokemons.Count; k++)
                            {
                                if (trainersAndPokemons[i].Pokemons[k].PokemonElement != "Water")
                                {
                                    trainersAndPokemons[i].Pokemons[k].PokemonHealth -= 10;
                                    if (trainersAndPokemons[i].Pokemons[k].PokemonHealth <= 0)
                                    {
                                        trainersAndPokemons[i].Pokemons.Remove(trainersAndPokemons[i].Pokemons[k]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var trainer in trainersAndPokemons.OrderByDescending(x=>x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.TrainerName} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}

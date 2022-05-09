using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInput[0];
                string pokemonName = trainerInput[1];
                string pokemonElement = trainerInput[2];
                int pokemonHealth = int.Parse(trainerInput[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                    {
                        Trainer trainer = new Trainer(trainerName);
                        trainers.Add(trainerName, trainer);
                    }
                
                trainers[trainerName].Pokemons.Add(pokemon);
            }

            string elementInput;
            while ((elementInput = Console.ReadLine()) != "End")
            {
                foreach ((string trainerName, Trainer trainer) in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == elementInput))
                    {
                        trainer.NumBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            Pokemon pokemon = trainer.Pokemons[i];
                            pokemon.Health -= 10;
                            
                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                                i--;
                            }
                        }
                    }
                }
            }

            trainers = trainers.OrderByDescending(t => t.Value.NumBadges)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer.Value.ToString());                
            }
            
        }
    }
}

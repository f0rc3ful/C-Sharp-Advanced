using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PokemonTrainer
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Trainer> trainersList = new Dictionary<string, Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputArr = input.Split(" ");
                string trainerName = inputArr[0];
                string pokemonName = inputArr[1];
                string pokemonElement = inputArr[2];
                int pokemonHealth = int.Parse(inputArr[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainersList.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName, new List<Pokemon> { pokemon });
                    trainersList.Add(trainerName, trainer);
                }
                else
                {
                    trainersList[trainerName].Pokemon.Add(pokemon);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Fire")
                {
                    foreach (var trainer in trainersList.Values)
                    {
                        if (trainer.Pokemon.Any(pokemon => pokemon.Element == "Fire"))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            trainer.Pokemon.Select(pokemon => pokemon.Health -= 10);
                        }
                        trainer.Pokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                else if (input == "Water")
                {
                    foreach (var trainer in trainersList.Values)
                    {
                        if (trainer.Pokemon.Any(pokemon => pokemon.Element == "Water"))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            trainer.Pokemon.Select(pokemon => pokemon.Health -= 10);
                        }
                        trainer.Pokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                else if (input == "Electricity")
                {
                    foreach (var trainer in trainersList.Values)
                    {
                        if (trainer.Pokemon.Any(pokemon => pokemon.Element == "Electricity"))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            trainer.Pokemon.Select(pokemon => pokemon.Health -= 10);
                        }
                        trainer.Pokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }

            }

            trainersList = trainersList.OrderByDescending(trainer => trainer.Value.Badges).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var trainer in trainersList)
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemon.Count()}");
            }
        }
    }
}

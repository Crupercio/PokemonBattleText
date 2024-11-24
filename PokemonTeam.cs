using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    public class PokemonTeam
    {
        public List<Pokemon> Team { get; private set; }
        private const int MaxTeamSize = 4; // Maximum number of Pokémon in a team

        public PokemonTeam()
        {
            Team = new List<Pokemon>();
        }

        // Add a Pokémon to the team
        public bool AddPokemon(Pokemon pokemon)
        {
            if (Team.Count >= MaxTeamSize)
            {
                Console.WriteLine("Your team is already full!");
                return false;
            }

            Team.Add(pokemon);
            Console.WriteLine($"{pokemon.Name} has been added to your team!");
            return true;
        }

        // Remove a Pokémon from the team
        public bool RemovePokemon(string pokemonName)
        {
            var pokemon = Team.FirstOrDefault(p => p.Name.Equals(pokemonName, StringComparison.OrdinalIgnoreCase));
            if (pokemon != null)
            {
                Team.Remove(pokemon);
                Console.WriteLine($"{pokemon.Name} has been removed from your team!");
                return true;
            }

            Console.WriteLine($"{pokemonName} is not in your team.");
            return false;
        }

        // Display the team
        public void DisplayTeam()
        {
            Console.WriteLine("\nYour Pokémon Team:");
            for (int i = 0; i < Team.Count; i++)
            {
                var pokemon = Team[i];
                Console.WriteLine($"{i + 1}. {pokemon.Name} - HP: {pokemon.HP}, Level: {pokemon.Level}, Fainted: {pokemon.Fainted}");
            }
        }

        // Swap positions of Pokémon in the team
        public void SwapPositions(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= Team.Count || secondIndex < 0 || secondIndex >= Team.Count)
            {
                Console.WriteLine("Invalid positions! Please try again.");
                return;
            }

            var temp = Team[firstIndex];
            Team[firstIndex] = Team[secondIndex];
            Team[secondIndex] = temp;

            Console.WriteLine($"Swapped positions of {Team[firstIndex].Name} and {Team[secondIndex].Name}.");
        }

        // Get Pokémon by position
        public Pokemon GetPokemonAtPosition(int position)
        {
            return position >= 0 && position < Team.Count ? Team[position] : null;
        }
    }

}

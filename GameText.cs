using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    public class GameText
    {
        // Intro Text
        public static void DisplayIntro()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*   Welcome to the Pokémon Battle!   *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("In this adventure, you will assemble a team of 4 Pokémon.");
            Console.WriteLine("Each Pokémon has unique abilities, including:");
            Console.WriteLine("- Standard Attack: A basic move for consistent damage.");
            Console.WriteLine("- Special Move: A powerful ability that can turn the tide.");
            Console.WriteLine("- Chase Move: A combo-triggered attack.");
            Console.WriteLine("- Passive Ability: Provides support or extra damage.");
            Console.WriteLine();
            Console.WriteLine("The battles are round-based and position-based. Strategy and positioning are key to victory.");
            Console.WriteLine("Here’s how it works:");
            Console.WriteLine("- Pokémon are assigned positions from 1 to 4 within your team.");
            Console.WriteLine("- In each round, Pokémon act in order based on their position.");
            Console.WriteLine("- Pokémon in position 1 will act before those in position 2, regardless of speed.");
            Console.WriteLine("- If two Pokémon occupy the same position (e.g., position 1), the one with higher speed will act first.");
            Console.WriteLine("- Special moves may override this order if they have priority effects.");
            Console.WriteLine();
            Console.WriteLine("Are you ready to master the art of strategy and lead your team to victory?");
            
        }

        // Leveling Up Text
        public static void DisplayLevelUp(string pokemonName, int newLevel)
        {
            Console.WriteLine($"Congratulations! Your {pokemonName} leveled up!");
            Console.WriteLine($"{pokemonName} is now Level {newLevel}.");
        }

        // Training Text
        public static void DisplayTraining(string pokemonName)
        {
            Console.WriteLine($"Your {pokemonName} is training hard!");
            Console.WriteLine($"{pokemonName}'s stats are improving!");
        }

        // Capturing Text
        public static void DisplayCaptureSuccess(string pokemonName)
        {
            Console.WriteLine($"You successfully captured {pokemonName}!");
        }

        public static void DisplayCaptureFailure()
        {
            Console.WriteLine("The Pokémon escaped! Better luck next time.");
        }

        public void AskPersonalQuestions(PokemonTeam playerTeam)
        {
            Console.WriteLine("\nLet's learn a bit about you!");

            // Favorite Color
            Console.WriteLine("\nWhat is your favorite color?");
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {colors[i]}");
            }
            string favoriteColor = GetUserSelection(colors);

            // Favorite Food
            Console.WriteLine("\nWhat is your favorite food?");
            string[] foods = { "Pizza", "Sushi", "Tacos", "Pasta", "Curry", "Burgers", "Dim Sum" };
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {foods[i]}");
            }
            string favoriteFood = GetUserSelection(foods);

            // Favorite Sport
            Console.WriteLine("\nWhat is your favorite sport?");
            string[] sports = { "Soccer", "Basketball", "Tennis", "Chess", "Baseball", "Video Games", "Cricket" };
            for (int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sports[i]}");
            }
            string favoriteSport = GetUserSelection(sports);

            // Add Pokémon based on answers
            AddPokemonBasedOnAnswer(favoriteColor, ColorToTypes, "color", playerTeam);
            AddPokemonBasedOnAnswer(favoriteFood, FoodToTypes, "food", playerTeam);
            AddPokemonBasedOnAnswer(favoriteSport, SportToTypes, "sport", playerTeam);

            Console.WriteLine("\nYour team is growing! Let's continue your adventure.");
        }




        // Helper method to get user selection
        private static string GetUserSelection(string[] options)
{
    while (true)
    {
        Console.WriteLine("Enter the number of your choice:");
        if (int.TryParse(Console.ReadLine(), out int selection) && selection > 0 && selection <= options.Length)
        {
            return options[selection - 1];
        }
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


     

        public void AddPokemonBasedOnAnswer(string answer, Dictionary<string, List<string>> answerToTypes, string answerType, PokemonTeam playerTeam)
        {
            if (!answerToTypes.ContainsKey(answer)) return;

            var types = answerToTypes[answer];
            var randomType = types[new Random().Next(types.Count)];
            var randomPokemon = GenerateRandomPokemonByType(randomType);

            if (randomPokemon != null)
            {
                Console.WriteLine($"\n{randomPokemon.Name} loves {answerType} '{answer}' and has been added to your team!");
                playerTeam.AddPokemon(randomPokemon);
            }
            else
            {
                Console.WriteLine($"\nNo Pokémon available for {answerType} '{answer}'.");
            }
        }



        // Generate a random Pokémon based on type
        private Pokemon GenerateRandomPokemonByType(string type)
        {
            var pokemonPool = PokemonData.GetAllPokemonByType(type)
                .Where(p => p.Name != "Mew" && p.Name != "Mewtwo") // Exclude legendaries
                .ToList();

            if (pokemonPool.Count == 0)
            {
                Console.WriteLine($"No Pokémon available for type '{type}'.");
                return null;
            }

            var random = new Random();
            var selectedPokemon = pokemonPool[random.Next(pokemonPool.Count)];

            return new Pokemon
            {
                Name = selectedPokemon.Name,
                HP = 80,
                Attack = 5,
                MagicAttack = 5,
                Defense = 5,
                SpecialDefense = 5,
                Speed = 5,
                Level = 1,
                TrainingPoints = 10,
                Strengths = selectedPokemon.Strengths,
                Weaknesses = selectedPokemon.Weaknesses,
                Type = selectedPokemon.Type,
                Type2 = selectedPokemon.Type2,
                StandardAttack = selectedPokemon.StandardAttack,
                ChaseAttack = selectedPokemon.ChaseAttack,
                MysteryAttack = selectedPokemon.MysteryAttack,
                PassiveMove = selectedPokemon.PassiveMove
            };
        }



        private readonly Dictionary<string, List<string>> ColorToTypes = new()
        {
            { "Red", new List<string> { "Fire", "Dark" } },
            { "Orange", new List<string> { "Fire", "Ground" } },
            { "Yellow", new List<string> { "Electric", "Psychic" } },
            { "Green", new List<string> { "Grass", "Bug" } },
            { "Blue", new List<string> { "Water", "Ice" } },
            { "Indigo", new List<string> { "Ghost", "Poison" } },
            { "Violet", new List<string> { "Fairy", "Psychic" } }
        };

        private readonly Dictionary<string, List<string>> FoodToTypes = new()
        {
            { "Pizza", new List<string> { "Fire", "Rock" } },
            { "Sushi", new List<string> { "Water", "Ice" } },
            { "Tacos", new List<string> { "Ground", "Poison" } },
            { "Pasta", new List<string> { "Grass", "Fairy" } },
            { "Curry", new List<string> { "Fire", "Fighting" } },
            { "Burgers", new List<string> { "Normal", "Fighting" } },
            { "Dim Sum", new List<string> { "Dragon", "Flying" } }
        };

        private readonly Dictionary<string, List<string>> SportToTypes = new()
        {
            { "Soccer", new List<string> { "Grass", "Flying" } },
            { "Basketball", new List<string> { "Fighting", "Electric" } },
            { "Tennis", new List<string> { "Fairy", "Psychic" } },
            { "Chess", new List<string> { "Psychic", "Dark" } },
            { "Baseball", new List<string> { "Normal", "Steel" } },
            { "Video Games", new List<string> { "Electric", "Steel" } },
            { "Cricket", new List<string> { "Bug", "Grass" } }
        };




    }

}

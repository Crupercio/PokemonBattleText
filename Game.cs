using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    internal class Game
    {
        private Map _map;
        private PokemonTeam _playerTeam = new PokemonTeam();
        GameText gameText = new GameText();


        public void Start()
        {
            _map = new Map();
            

            SelectStarterPokemon(); // Call starter Pokémon selection and personal questions
            
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Check Nearby Areas");
                Console.WriteLine("2. Travel to Another Area");
                Console.WriteLine("3. Explore Route");
                Console.WriteLine("4. Pokémon Menu");
                Console.WriteLine("5. Exit Game");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayNearbyAreas();
                        break;
                    case "2":
                        TravelToAnotherArea();
                        break;
                    case "3":
                        _map.ExploreRoute();
                        break;
                    case "4":
                        PokemonMenu();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for playing!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        private void DisplayNearbyAreas()
        {
            var nearbyAreas = _map.GetNearbyAreas();
            if (nearbyAreas == null || nearbyAreas.Count == 0)
            {
                Console.WriteLine("\nNo nearby areas available.");
                return;
            }

            Console.WriteLine("\nNearby Areas:");
            for (int i = 0; i < nearbyAreas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {nearbyAreas[i]}");
            }
        }

        private void TravelToAnotherArea()
        {
            var nearbyAreas = _map.GetNearbyAreas();
            if (nearbyAreas == null || nearbyAreas.Count == 0)
            {
                Console.WriteLine("\nNo nearby areas available to travel.");
                return;
            }

            DisplayNearbyAreas();

            Console.WriteLine("\nSelect an area to travel by number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int selection) && selection > 0 && selection <= nearbyAreas.Count)
            {
                string selectedArea = nearbyAreas[selection - 1];
                if (_map.TravelToArea(selectedArea))
                {
                    Console.WriteLine($"You traveled to {selectedArea}.");
                }
                else
                {
                    Console.WriteLine("An error occurred while traveling. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number corresponding to the area.");
            }
        }

        private void PokemonMenu()
        {
            bool inPokemonMenu = true;
            while (inPokemonMenu)
            {
                Console.WriteLine("\nPokémon Menu:");
                Console.WriteLine("1. Train Pokémon");
                Console.WriteLine("2. Feed Pokémon");
                Console.WriteLine("3. Position Pokémon");
                Console.WriteLine("4. Display Moves");
                Console.WriteLine("5. Display Team");
                Console.WriteLine("6. Back to Main Menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TrainPokemon();
                        break;
                    case "2":
                        FeedPokemon();
                        break;
                    case "3":
                        PositionPokemon();
                        break;
                    case "4":
                        DisplayMoves();
                        break;
                    case "5":
                        DisplayTeam(); // New option to display the team
                        break;
                    case "6":
                        inPokemonMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        private void DisplayTeam()
        {
            if (_playerTeam.Team.Count == 0)
            {
                Console.WriteLine("\nYour team is empty!");
                return;
            }

            Console.WriteLine("\nYour Pokémon Team:");
            for (int i = 0; i < _playerTeam.Team.Count; i++)
            {
                var pokemon = _playerTeam.Team[i];
                Console.WriteLine($"{i + 1}. {pokemon.Name} - HP: {pokemon.HP}, Level: {pokemon.Level}, Fainted: {pokemon.Fainted}");
            }
        }


        public void TrainPokemon()
        {
            if (_playerTeam.Team.Count == 0)
            {
                Console.WriteLine("\nYou have no Pokémon to train!");
                return;
            }

            Console.WriteLine("\nChoose a Pokémon to train:");
            for (int i = 0; i < _playerTeam.Team.Count; i++)
            {
                var pokemon = _playerTeam.Team[i];
                Console.WriteLine($"{i + 1}. {pokemon.Name} - Training Points: {pokemon.TrainingPoints}, Level: {pokemon.Level}");
            }
            Console.WriteLine($"{_playerTeam.Team.Count + 1}. Back to Pokémon Menu");

            if (int.TryParse(Console.ReadLine(), out int selection) && selection > 0 && selection <= _playerTeam.Team.Count)
            {
                var selectedPokemon = _playerTeam.Team[selection - 1];

                if (selectedPokemon.TrainingPoints <= 0)
                {
                    Console.WriteLine($"\n{selectedPokemon.Name} has no training points left! Level up to earn more.");
                    return;
                }

                Console.WriteLine("\nChoose a training program:");
                Console.WriteLine("1. Power Punch Training (Strength -> Attack)");
                Console.WriteLine("2. Quick Dash Drills (Agility -> Speed)");
                Console.WriteLine("3. Iron Wall Defense (Durability -> Defense)");
                Console.WriteLine("4. Mystic Shield Practice (Resistance -> Special Defense)");
                Console.WriteLine("5. Mind Spark Sessions (Intelligence -> Special Attack)");
                Console.WriteLine("6. Back to Pokémon Menu");

                if (int.TryParse(Console.ReadLine(), out int trainingSelection) && trainingSelection >= 1 && trainingSelection <= 5)
                {
                    ExecuteTraining(selectedPokemon, trainingSelection);
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to Pokémon Menu.");
                }
            }
            else
            {
                Console.WriteLine("Returning to Pokémon Menu.");
            }
        }
        private void ExecuteTraining(Pokemon pokemon, int trainingType)
        {
            var random = new Random();
            int statIncrease = random.Next(2, 5); // Gain 2-4 stat points
            pokemon.TrainingPoints--; // Deduct 1 training point

            string feedback = string.Empty;

            switch (trainingType)
            {
                case 1: // Power Punch Training
                    pokemon.Attack += statIncrease;
                    feedback = $"{pokemon.Name} completed {pokemon.Level * 10} push-ups and gained {statIncrease} Attack points!";
                    break;

                case 2: // Quick Dash Drills
                    pokemon.Speed += statIncrease;
                    feedback = $"{pokemon.Name} sprinted through an agility course, gaining {statIncrease} Speed points!";
                    break;

                case 3: // Iron Wall Defense
                    pokemon.Defense += statIncrease;
                    feedback = $"{pokemon.Name} braced against heavy winds, gaining {statIncrease} Defense points!";
                    break;

                case 4: // Mystic Shield Practice
                    pokemon.SpecialDefense += statIncrease;
                    feedback = $"{pokemon.Name} meditated under a waterfall, gaining {statIncrease} Special Defense points!";
                    break;

                case 5: // Mind Spark Sessions
                    pokemon.MagicAttack += statIncrease;
                    feedback = $"{pokemon.Name} read an ancient tome and gained {statIncrease} Special Attack points!";
                    break;

                default:
                    Console.WriteLine("Invalid training program selected.");
                    return;
            }

            Console.WriteLine(feedback);
            Console.WriteLine($"{pokemon.Name} has {pokemon.TrainingPoints} training points remaining.");
        }

        private int CalculateDamage(Pokemon attacker, Pokemon defender, Move move)
        {
            var random = new Random();
            int randomVariance = random.Next(-5, 6); // Add slight randomness to damage

            if (move.IsPhysical)
            {
                // Physical move damage
                return (int)((move.Power * (attacker.Attack / (float)defender.Defense)) + randomVariance);
            }
            else
            {
                // Special move damage
                return (int)((move.Power * (attacker.MagicAttack / (float)defender.SpecialDefense)) + randomVariance);
            }
        }
      



        private void FeedPokemon() { /* Implement FeedPokemon logic */ }
        private void PositionPokemon() { /* Implement PositionPokemon logic */ }
        private void DisplayMoves()
        {
            if (_playerTeam.Team.Count == 0)
            {
                Console.WriteLine("\nYou have no Pokémon in your team!");
                return;
            }

            Console.WriteLine("\nChoose a Pokémon to view its moves:");
            for (int i = 0; i < _playerTeam.Team.Count; i++)
            {
                var pokemon = _playerTeam.Team[i];
                Console.WriteLine($"{i + 1}. {pokemon.Name}");
            }
            Console.WriteLine($"{_playerTeam.Team.Count + 1}. Back to Pokémon Menu");

            if (int.TryParse(Console.ReadLine(), out int selection) && selection > 0 && selection <= _playerTeam.Team.Count)
            {
                var selectedPokemon = _playerTeam.Team[selection - 1];
                DisplayPokemonMoves(selectedPokemon);
            }
            else
            {
                Console.WriteLine("\nReturning to Pokémon Menu.");
            }
        }

        private void DisplayPokemonMoves(Pokemon pokemon)
        {
            Console.WriteLine($"\nMoves for {pokemon.Name}:");

            DisplayMoveDetails("Standard Attack", pokemon.StandardAttack);
            DisplayMoveDetails("Chase Attack", pokemon.ChaseAttack);
            DisplayMoveDetails("Mystery Attack", pokemon.MysteryAttack);
            DisplayMoveDetails("Passive Move", pokemon.PassiveMove);
        }

        private void DisplayMoveDetails(string moveType, Move move)
        {
            if (move == null)
            {
                Console.WriteLine($"- {moveType}: None");
                return;
            }

            Console.WriteLine($"\n- {moveType}:");
            Console.WriteLine($"  Name: {move.Name}");
            Console.WriteLine($"  Power: {move.Power}");
            Console.WriteLine($"  Type: {move.Type}");
            if (!string.IsNullOrEmpty(move.Trigger))
                Console.WriteLine($"  Chase Trigger: {move.Trigger}");
            if (!string.IsNullOrEmpty(move.Effect))
                Console.WriteLine($"  Effect: {move.Effect}");
            if (move.Cost > 0)
                Console.WriteLine($"  Cost: {move.Cost} energy");
        }


        private void SelectStarterPokemon()
        {
            Console.WriteLine("\nWelcome to the world of Pokémon!");
            Console.WriteLine("Before we begin, you must select your starter Pokémon.");

            bool selecting = true;

            while (selecting)
            {
                // Display starter Pokémon
                Console.WriteLine("\nStarter Pokémon:");
                foreach (var starter in PokemonData.GetAllStarterPokemons())
                {
                    Console.WriteLine($"ID: {starter.Key}, Name: {starter.Value}");
                }

                // Prompt for selection
                Console.WriteLine("\nSelect a starter Pokémon by ID (1 for Bulbasaur, 4 for Charmander, 7 for Squirtle, 25 for Pikachu):");
                Console.WriteLine("Or type 'EXIT' to quit the game.");
                string selection = Console.ReadLine()?.ToUpper();

                if (selection == "EXIT")
                {
                    Console.WriteLine("Goodbye! See you next time!");
                    Environment.Exit(0); // Exit the program
                }
                else
                {
                    // Parse input and validate selection
                    if (int.TryParse(selection, out int selectedId))
                    {
                        string selectedPokemon = PokemonData.GetStarterPokemonById(selectedId);

                        if (selectedPokemon == "Unknown Starter")
                        {
                            Console.WriteLine("Invalid selection. Please try again!");
                        }
                        else
                        {
                            Console.WriteLine($"You selected {selectedPokemon} as your starter Pokémon!");

                            // Add selected Pokémon to player's team
                            if (_playerTeam.AddPokemon(new Pokemon
                            {
                                Name = selectedPokemon,
                                HP = 80,
                                Attack = 5,
                                MagicAttack = 5,
                                Defense = 5,
                                SpecialDefense = 5,
                                Speed = 5,
                                Level = 1, // Set the level to 1 for starter Pokémon
                                Experience = 0,
                                TrainingPoints = 10, // Training points for level 1
                                Type = "Electric", // Example type; adjust based on starter
                                Strengths = new List<string> { "Flying", "Water" },
                                Weaknesses = new List<string> { "Ground" },
                                StandardAttack = new Move { Name = "Thunder Shock", Power = 40, Type = "Electric" },
                                ChaseAttack = new Move { Name = "Quick Attack", Power = 50, Type = "Normal", Trigger = "Hit 10 times" },
                                MysteryAttack = new Move { Name = "Thunderbolt", Power = 90, Type = "Electric" },
                                PassiveMove = new Move { Name = "Static", Effect = "May paralyze opponent when hit" }
                            }))
                            {
                                Console.WriteLine($"{selectedPokemon} is now part of your team!");
                            }


                            // Ask personal questions
                            gameText.AskPersonalQuestions(_playerTeam);

                            selecting = false; // Exit the loop
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid ID or type 'EXIT'.");
                    }
                }
            }
        }

    }

}

namespace PokemonBattleText
{
    // Class to represent a City
    public class City
    {
        public string Name { get; set; }
        public Gym Gym { get; set; }
        public List<string> NearbyAreas { get; set; }
    }
    // Class to represent a Route
    public class Route
    {
        public string Name { get; set; }
        public List<string> WildPokemonTypes { get; set; }
        public string Description { get; set; }
        public List<string> NearbyAreas { get; set; }
    }
    // Class to represent a Gym
    public class Gym
    {
        public string LeaderName { get; set; }
        public string Specialty { get; set; }
        public string Description { get; set; }
    }



    public class Map
    {
        // Store cities and routes in dictionaries
        private readonly Dictionary<string, City> _cities;
        private readonly Dictionary<string, Route> _routes;

        // Current player location
        public string CurrentLocation { get; private set; }

        public Map()
        {
            // Initialize cities and routes
            _cities = InitializeCities();
            _routes = InitializeRoutes();

            // Set the starting location
            CurrentLocation = "Capital City";
        }

        // Initialize cities
        private Dictionary<string, City> InitializeCities()
        {
            return new Dictionary<string, City>
    {
        {
            "Capital City",
            new City
            {
                Name = "Capital City",
                Gym = new Gym
                {
                    LeaderName = "Don Vittorio",
                    Specialty = "Steel and Dark types",
                    Description = "A charismatic leader in a pinstripe suit, known for his 'Iron Resolve.'"
                },
                NearbyAreas = new List<string> { "Marble Path", "Verdant Trail" }
            }
        },
        {
            "La Hacienda",
            new City
            {
                Name = "La Hacienda",
                Gym = new Gym
                {
                    LeaderName = "El Patrón",
                    Specialty = "Ground and Fire types",
                    Description = "A powerful figure with a sombrero and a poncho, ruling with a fiery temper."
                },
                NearbyAreas = new List<string> { "Desert Dunes", "Canyon Pass", "Riverbank Trail" }
            }
        },
        {
            "Neo-Tokyo",
            new City
            {
                Name = "Neo-Tokyo",
                Gym = new Gym
                {
                    LeaderName = "Kenji-san",
                    Specialty = "Electric and Poison types",
                    Description = "A disciplined leader with a sharp katana, embodying honor and strength."
                },
                NearbyAreas = new List<string> { "Verdant Trail", "Shadowed Forest", "Cliffside Trail" }
            }
        },
        {
            "Shanghai Streets",
            new City
            {
                Name = "Shanghai Streets",
                Gym = new Gym
                {
                    LeaderName = "Madame Ling",
                    Specialty = "Dragon and Fighting types",
                    Description = "A mysterious figure in traditional qipao, known for her tactical brilliance."
                },
                NearbyAreas = new List<string> { "Dragon’s Crossing", "Lotus Valley" }
            }
        },
        {
            "Moscow Square",
            new City
            {
                Name = "Moscow Square",
                Gym = new Gym
                {
                    LeaderName = "Boris the Bear",
                    Specialty = "Ice and Fighting types",
                    Description = "A burly leader with a fur coat, wielding cold precision in battle."
                },
                NearbyAreas = new List<string> { "Frozen Trail", "Glacial Pass" }
            }
        },
        {
            "Little Havana",
            new City
            {
                Name = "Little Havana",
                Gym = new Gym
                {
                    LeaderName = "Señor Castillo",
                    Specialty = "Grass and Water types",
                    Description = "A suave figure with a cigar, known for his laid-back demeanor."
                },
                NearbyAreas = new List<string> { "Tropical Shoreline", "Mangrove Swamp" }
            }
        },
        {
            "Marseille Port",
            new City
            {
                Name = "Marseille Port",
                Gym = new Gym
                {
                    LeaderName = "La Femme Fatale (Isabelle)",
                    Specialty = "Fairy and Psychic types",
                    Description = "A cunning leader dressed elegantly, manipulating battles with finesse."
                },
                NearbyAreas = new List<string> { "Sapphire Bay", "Riviera Trail" }
            }
        },
        {
            "Hamburg Warehouse",
            new City
            {
                Name = "Hamburg Warehouse",
                Gym = new Gym
                {
                    LeaderName = "Herr Krieger",
                    Specialty = "Rock and Steel types",
                    Description = "A strongman in a trench coat, commanding with military precision."
                },
                NearbyAreas = new List<string> { "Industrial Zone", "Granite Road" }
            }
        },
        {
            "New York Heights",
            new City
            {
                Name = "New York Heights",
                Gym = new Gym
                {
                    LeaderName = "Big Tony",
                    Specialty = "Normal and Fighting types",
                    Description = "A classic mob boss with suspenders, known for his brute force."
                },
                NearbyAreas = new List<string> { "City Boulevard", "Concrete Jungle" }
            }
        },
        {
            "Shadow Isle",
            new City
            {
                Name = "Shadow Isle",
                Gym = new Gym
                {
                    LeaderName = "The Council (A Group)",
                    Specialty = "Ghost and Dark types",
                    Description = "A secretive council representing all the syndicates, combining their powers."
                },
                NearbyAreas = new List<string> { "Haunted Harbor", "Midnight Path" }
            }
        }
    };
        }


        // Initialize routes
        private Dictionary<string, Route> InitializeRoutes()
        {
            return new Dictionary<string, Route>
    {
        {
            "Marble Path",
            new Route
            {
                Name = "Marble Path",
                WildPokemonTypes = new List<string> { "Grass", "Bug", "Fairy" },
                Description = "A scenic route leading to La Hacienda, with cobblestone roads and fields of flowers.",
                NearbyAreas = new List<string> { "Capital City", "La Hacienda" }
            }
        },
        {
            "Verdant Trail",
            new Route
            {
                Name = "Verdant Trail",
                WildPokemonTypes = new List<string> { "Bug", "Grass", "Flying" },
                Description = "Connects to Neo-Tokyo through dense forests with occasional clearings.",
                NearbyAreas = new List<string> { "Capital City", "Neo-Tokyo" }
            }
        },
        {
            "Desert Dunes",
            new Route
            {
                Name = "Desert Dunes",
                WildPokemonTypes = new List<string> { "Ground", "Fire", "Rock" },
                Description = "A sandy trail filled with cacti and mirages, connecting to Capital City.",
                NearbyAreas = new List<string> { "La Hacienda", "Canyon Pass" }
            }
        },
        {
            "Shadowed Forest",
            new Route
            {
                Name = "Shadowed Forest",
                WildPokemonTypes = new List<string> { "Ghost", "Bug", "Dark" },
                Description = "A mystical wooded route leading to Shanghai Streets.",
                NearbyAreas = new List<string> { "Neo-Tokyo", "Shanghai Streets" }
            }
        },
        {
            "Frozen Trail",
            new Route
            {
                Name = "Frozen Trail",
                WildPokemonTypes = new List<string> { "Ice", "Fighting", "Ground" },
                Description = "A snow-covered route leading to Moscow Square.",
                NearbyAreas = new List<string> { "Moscow Square", "Hamburg Warehouse" }
            }
        },
        {
            "Sapphire Bay",
            new Route
            {
                Name = "Sapphire Bay",
                WildPokemonTypes = new List<string> { "Water", "Fairy", "Flying" },
                Description = "A coastal path connecting to Little Havana.",
                NearbyAreas = new List<string> { "Marseille Port", "Little Havana" }
            }
        },
        {
            "City Boulevard",
            new Route
            {
                Name = "City Boulevard",
                WildPokemonTypes = new List<string> { "Normal", "Fighting", "Electric" },
                Description = "A bustling street connecting to Capital City.",
                NearbyAreas = new List<string> { "New York Heights", "Shadow Isle" }
            }
        },
        {
            "Midnight Path",
            new Route
            {
                Name = "Midnight Path",
                WildPokemonTypes = new List<string> { "Ghost", "Psychic", "Dark" },
                Description = "A shadowy route leading to New York Heights.",
                NearbyAreas = new List<string> { "Shadow Isle", "New York Heights" }
            }
        }
    };
        }


        public void ExploreRoute()
        {
            if (_routes.ContainsKey(CurrentLocation))
            {
                var route = _routes[CurrentLocation];
                Console.WriteLine($"\nExploring {route.Name}...");
                WildEncounter();
            }
            else
            {
                Console.WriteLine("You can only explore on routes!");
            }
        }

        public void WildEncounter()
        {
            Console.WriteLine("A wild Pokémon battle begins!");
            var wildTeam = GenerateWildTeam();
            Console.WriteLine("The wild team is:");
            foreach (var pokemon in wildTeam)
            {
                Console.WriteLine($"- {pokemon.Name} (Position {pokemon.Position})");
            }

            Console.WriteLine("\nPrepare for battle!");
        }

        private List<Pokemon> GenerateWildTeam()
        {
            var route = _routes[CurrentLocation];
            var wildTeam = new List<Pokemon>();
            var random = new Random();

            for (int i = 0; i < 4; i++)
            {
                wildTeam.Add(GenerateRandomPokemon(route.WildPokemonTypes));
            }

            var positions = new List<int> { 1, 2, 3, 4 };
            positions = positions.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < wildTeam.Count; i++)
            {
                wildTeam[i].Position = positions[i].ToString(); // Convert int to string
            }


            return wildTeam;
        }

        private Pokemon GenerateRandomPokemon(List<string> types)
        {
            var random = new Random();
            string type = types[random.Next(types.Count)];
            string name = type switch
            {
                "Grass" => "Bellsprout",
                "Bug" => "Caterpie",
                "Fairy" => "Clefairy",
                "Flying" => "Pidgey",
                "Ghost" => "Gastly",
                _ => "Unknown"
            };

            return new Pokemon { Name = name };
        }

        public void DisplayCurrentLocation()
        {
            Console.WriteLine("\n----------------------------------");
            if (_cities.ContainsKey(CurrentLocation))
            {
                var city = _cities[CurrentLocation];
                Console.WriteLine($"You are in {city.Name}, home of {city.Gym.LeaderName}.");
            }
            else if (_routes.ContainsKey(CurrentLocation))
            {
                var route = _routes[CurrentLocation];
                Console.WriteLine($"You are on {route.Name}. {route.Description}");
            }
            else
            {
                Console.WriteLine("Unknown location.");
            }
            Console.WriteLine("----------------------------------\n");
        }

        public List<string> GetNearbyAreas()
        {
            if (_cities.ContainsKey(CurrentLocation) && _cities[CurrentLocation].NearbyAreas != null)
            {
                return _cities[CurrentLocation].NearbyAreas;
            }
            else if (_routes.ContainsKey(CurrentLocation) && _routes[CurrentLocation].NearbyAreas != null)
            {
                return _routes[CurrentLocation].NearbyAreas;
            }
            else
            {
                return new List<string>();
            }
        }

        public bool TravelToArea(string areaName)
        {
            var nearbyAreas = GetNearbyAreas();
            if (nearbyAreas.Contains(areaName))
            {
                CurrentLocation = areaName;
                return true;
            }
            return false;
        }

        public bool IsCurrentLocationRoute()
        {
            return _routes.ContainsKey(CurrentLocation);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    using System;
    using System.Collections.Generic;

    public static class PokemonData
    {
        // Dictionary to store starter Pokémon
        private static readonly Dictionary<int, string> StarterPokemons = new Dictionary<int, string>
        {
            { 1, "Bulbasaur" },
            { 4, "Charmander" },
            { 7, "Squirtle" },
            { 25, "Pikachu" }
        };

        private static readonly List<Pokemon> AllPokemon = new List<Pokemon>
        {
            new Pokemon { Name = "Bulbasaur", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Ivysaur", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Venusaur", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Charmander", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Charmeleon", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Charizard", Type = "Fire", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Electric", "Rock" } },
            new Pokemon { Name = "Squirtle", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Wartortle", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Blastoise", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Caterpie", Type = "Bug", Type2 = "None", Strengths = new List<string> { "Grass", "Psychic", "Dark" }, Weaknesses = new List<string> { "Fire", "Flying", "Rock" } },
            new Pokemon { Name = "Metapod", Type = "Bug", Type2 = "None", Strengths = new List<string> { "Grass", "Psychic", "Dark" }, Weaknesses = new List<string> { "Fire", "Flying", "Rock" } },
            new Pokemon { Name = "Butterfree", Type = "Bug", Type2 = "Flying", Strengths = new List<string> { "Grass", "Fighting", "Bug" }, Weaknesses = new List<string> { "Fire", "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Weedle", Type = "Bug", Type2 = "Poison", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Rock" } },
            new Pokemon { Name = "Kakuna", Type = "Bug", Type2 = "Poison", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Rock" } },
            new Pokemon { Name = "Beedrill", Type = "Bug", Type2 = "Poison", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Rock" } },
            new Pokemon { Name = "Pidgey", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Pidgeotto", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Pidgeot", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Rattata", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Raticate", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Spearow", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Fearow", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Ekans", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Arbok", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Pikachu", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Water", "Flying" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Raichu", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Water", "Flying" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Sandshrew", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Sandslash", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Nidoran♀", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Nidorina", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Nidoqueen", Type = "Poison", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Fairy" }, Weaknesses = new List<string> { "Water", "Psychic", "Ice" } },
            new Pokemon { Name = "Nidoran♂", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Nidorino", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Nidoking", Type = "Poison", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Fairy" }, Weaknesses = new List<string> { "Water", "Psychic", "Ice" } },
            new Pokemon { Name = "Clefairy", Type = "Fairy", Type2 = "None", Strengths = new List<string> { "Fighting", "Dragon" }, Weaknesses = new List<string> { "Steel", "Poison" } },
            new Pokemon { Name = "Clefable", Type = "Fairy", Type2 = "None", Strengths = new List<string> { "Fighting", "Dragon" }, Weaknesses = new List<string> { "Steel", "Poison" } },
            new Pokemon { Name = "Vulpix", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Ninetales", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Jigglypuff", Type = "Normal", Type2 = "Fairy", Strengths = new List<string> { "Fighting", "Dragon" }, Weaknesses = new List<string> { "Steel", "Poison" } },
            new Pokemon { Name = "Wigglytuff", Type = "Normal", Type2 = "Fairy", Strengths = new List<string> { "Fighting", "Dragon" }, Weaknesses = new List<string> { "Steel", "Poison" } },
            new Pokemon { Name = "Zubat", Type = "Poison", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Psychic", "Rock", "Ice" } },
            new Pokemon { Name = "Golbat", Type = "Poison", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Psychic", "Rock", "Ice" } },
            new Pokemon { Name = "Oddish", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Gloom", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Vileplume", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Paras", Type = "Bug", Type2 = "Grass", Strengths = new List<string> { "Water", "Ground", "Psychic" }, Weaknesses = new List<string> { "Fire", "Flying", "Bug", "Ice", "Poison" } },
            new Pokemon { Name = "Parasect", Type = "Bug", Type2 = "Grass", Strengths = new List<string> { "Water", "Ground", "Psychic" }, Weaknesses = new List<string> { "Fire", "Flying", "Bug", "Ice", "Poison" } },
            new Pokemon { Name = "Venonat", Type = "Bug", Type2 = "Poison", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Fire", "Flying", "Psychic", "Rock" } },
            new Pokemon { Name = "Venomoth", Type = "Bug", Type2 = "Poison", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Fire", "Flying", "Psychic", "Rock" } },
            new Pokemon { Name = "Diglett", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Dugtrio", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Meowth", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Persian", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Psyduck", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Golduck", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Mankey", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Primeape", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Growlithe", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Arcanine", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Poliwag", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Poliwhirl", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Poliwrath", Type = "Water", Type2 = "Fighting", Strengths = new List<string> { "Fire", "Ground", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Electric", "Grass", "Flying", "Psychic", "Fairy" } },
            new Pokemon { Name = "Abra", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Kadabra", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Alakazam", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Machop", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Machoke", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Machamp", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Bellsprout", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Weepinbell", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Victreebel", Type = "Grass", Type2 = "Poison", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Psychic", "Flying", "Ice" } },
            new Pokemon { Name = "Tentacool", Type = "Water", Type2 = "Poison", Strengths = new List<string> { "Fire", "Ground", "Rock", "Fairy" }, Weaknesses = new List<string> { "Electric", "Psychic", "Ground" } },
            new Pokemon { Name = "Tentacruel", Type = "Water", Type2 = "Poison", Strengths = new List<string> { "Fire", "Ground", "Rock", "Fairy" }, Weaknesses = new List<string> { "Electric", "Psychic", "Ground" } },
            new Pokemon { Name = "Geodude", Type = "Rock", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Poison", "Flying" }, Weaknesses = new List<string> { "Water", "Grass", "Ice", "Fighting", "Steel" } },
            new Pokemon { Name = "Graveler", Type = "Rock", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Poison", "Flying" }, Weaknesses = new List<string> { "Water", "Grass", "Ice", "Fighting", "Steel" } },
            new Pokemon { Name = "Golem", Type = "Rock", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Poison", "Flying" }, Weaknesses = new List<string> { "Water", "Grass", "Ice", "Fighting", "Steel" } },
            new Pokemon { Name = "Ponyta", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Rapidash", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Slowpoke", Type = "Water", Type2 = "Psychic", Strengths = new List<string> { "Fire", "Ground", "Rock", "Fighting", "Poison" }, Weaknesses = new List<string> { "Electric", "Grass", "Bug", "Dark", "Ghost" } },
            new Pokemon { Name = "Slowbro", Type = "Water", Type2 = "Psychic", Strengths = new List<string> { "Fire", "Ground", "Rock", "Fighting", "Poison" }, Weaknesses = new List<string> { "Electric", "Grass", "Bug", "Dark", "Ghost" } },
            new Pokemon { Name = "Magnemite", Type = "Electric", Type2 = "Steel", Strengths = new List<string> { "Flying", "Fairy", "Ice", "Rock" }, Weaknesses = new List<string> { "Fire", "Fighting", "Ground" } },
            new Pokemon { Name = "Magneton", Type = "Electric", Type2 = "Steel", Strengths = new List<string> { "Flying", "Fairy", "Ice", "Rock" }, Weaknesses = new List<string> { "Fire", "Fighting", "Ground" } },
            new Pokemon { Name = "Farfetch'd", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Doduo", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Dodrio", Type = "Normal", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Fighting" }, Weaknesses = new List<string> { "Electric", "Rock", "Ice" } },
            new Pokemon { Name = "Seel", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Dewgong", Type = "Water", Type2 = "Ice", Strengths = new List<string> { "Fire", "Ground", "Rock", "Grass", "Flying" }, Weaknesses = new List<string> { "Electric", "Rock", "Fighting" } },
            new Pokemon { Name = "Grimer", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Muk", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Shellder", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Cloyster", Type = "Water", Type2 = "Ice", Strengths = new List<string> { "Fire", "Ground", "Rock", "Grass", "Flying" }, Weaknesses = new List<string> { "Electric", "Rock", "Fighting" } },
            new Pokemon { Name = "Gastly", Type = "Ghost", Type2 = "Poison", Strengths = new List<string> { "Psychic", "Fairy", "Fighting", "Bug" }, Weaknesses = new List<string> { "Ghost", "Psychic", "Ground", "Dark" } },
            new Pokemon { Name = "Haunter", Type = "Ghost", Type2 = "Poison", Strengths = new List<string> { "Psychic", "Fairy", "Fighting", "Bug" }, Weaknesses = new List<string> { "Ghost", "Psychic", "Ground", "Dark" } },
            new Pokemon { Name = "Gengar", Type = "Ghost", Type2 = "Poison", Strengths = new List<string> { "Psychic", "Fairy", "Fighting", "Bug" }, Weaknesses = new List<string> { "Ghost", "Psychic", "Ground", "Dark" } },
            new Pokemon { Name = "Onix", Type = "Rock", Type2 = "Ground", Strengths = new List<string> { "Fire", "Electric", "Poison", "Flying" }, Weaknesses = new List<string> { "Water", "Grass", "Ice", "Fighting", "Steel" } },
            new Pokemon { Name = "Drowzee", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Hypno", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Krabby", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Kingler", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Voltorb", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Flying", "Water" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Electrode", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Flying", "Water" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Exeggcute", Type = "Grass", Type2 = "Psychic", Strengths = new List<string> { "Water", "Ground", "Rock", "Fighting", "Poison" }, Weaknesses = new List<string> { "Fire", "Flying", "Bug", "Dark", "Ice" } },
            new Pokemon { Name = "Exeggutor", Type = "Grass", Type2 = "Psychic", Strengths = new List<string> { "Water", "Ground", "Rock", "Fighting", "Poison" }, Weaknesses = new List<string> { "Fire", "Flying", "Bug", "Dark", "Ice" } },
            new Pokemon { Name = "Cubone", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Marowak", Type = "Ground", Type2 = "None", Strengths = new List<string> { "Fire", "Electric", "Poison", "Rock" }, Weaknesses = new List<string> { "Water", "Grass", "Ice" } },
            new Pokemon { Name = "Hitmonlee", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Hitmonchan", Type = "Fighting", Type2 = "None", Strengths = new List<string> { "Normal", "Rock", "Steel", "Ice", "Dark" }, Weaknesses = new List<string> { "Psychic", "Flying", "Fairy" } },
            new Pokemon { Name = "Lickitung", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Koffing", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Weezing", Type = "Poison", Type2 = "None", Strengths = new List<string> { "Grass", "Fairy" }, Weaknesses = new List<string> { "Psychic", "Ground" } },
            new Pokemon { Name = "Rhyhorn", Type = "Ground", Type2 = "Rock", Strengths = new List<string> { "Fire", "Electric", "Flying", "Poison" }, Weaknesses = new List<string> { "Water", "Grass", "Fighting", "Steel", "Ice" } },
            new Pokemon { Name = "Rhydon", Type = "Ground", Type2 = "Rock", Strengths = new List<string> { "Fire", "Electric", "Flying", "Poison" }, Weaknesses = new List<string> { "Water", "Grass", "Fighting", "Steel", "Ice" } },
            new Pokemon { Name = "Chansey", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Tangela", Type = "Grass", Type2 = "None", Strengths = new List<string> { "Water", "Ground", "Rock" }, Weaknesses = new List<string> { "Fire", "Flying", "Bug", "Ice", "Poison" } },
            new Pokemon { Name = "Kangaskhan", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Horsea", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Seadra", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Goldeen", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Seaking", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Staryu", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Starmie", Type = "Water", Type2 = "Psychic", Strengths = new List<string> { "Fire", "Ground", "Rock", "Fighting", "Poison" }, Weaknesses = new List<string> { "Electric", "Grass", "Bug", "Dark", "Ghost" } },
            new Pokemon { Name = "Mr. Mime", Type = "Psychic", Type2 = "Fairy", Strengths = new List<string> { "Fighting", "Dragon" }, Weaknesses = new List<string> { "Ghost", "Steel", "Poison" } },
            new Pokemon { Name = "Scyther", Type = "Bug", Type2 = "Flying", Strengths = new List<string> { "Grass", "Fighting", "Bug" }, Weaknesses = new List<string> { "Fire", "Flying", "Rock", "Electric" } },
            new Pokemon { Name = "Jynx", Type = "Ice", Type2 = "Psychic", Strengths = new List<string> { "Flying", "Grass", "Dragon", "Fighting", "Poison" }, Weaknesses = new List<string> { "Fire", "Dark", "Ghost", "Steel" } },
            new Pokemon { Name = "Electabuzz", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Flying", "Water" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Magmar", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Pinsir", Type = "Bug", Type2 = "None", Strengths = new List<string> { "Grass", "Psychic", "Dark" }, Weaknesses = new List<string> { "Fire", "Flying", "Rock" } },
            new Pokemon { Name = "Tauros", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Magikarp", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Gyarados", Type = "Water", Type2 = "Flying", Strengths = new List<string> { "Fire", "Ground", "Fighting", "Bug", "Steel" }, Weaknesses = new List<string> { "Electric", "Rock" } },
            new Pokemon { Name = "Lapras", Type = "Water", Type2 = "Ice", Strengths = new List<string> { "Fire", "Ground", "Rock", "Flying", "Grass" }, Weaknesses = new List<string> { "Electric", "Rock", "Fighting" } },
            new Pokemon { Name = "Ditto", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Eevee", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Vaporeon", Type = "Water", Type2 = "None", Strengths = new List<string> { "Fire", "Ground", "Rock" }, Weaknesses = new List<string> { "Electric", "Grass" } },
            new Pokemon { Name = "Jolteon", Type = "Electric", Type2 = "None", Strengths = new List<string> { "Flying", "Water" }, Weaknesses = new List<string> { "Ground" } },
            new Pokemon { Name = "Flareon", Type = "Fire", Type2 = "None", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Water", "Rock", "Ground" } },
            new Pokemon { Name = "Porygon", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Omanyte", Type = "Rock", Type2 = "Water", Strengths = new List<string> { "Fire", "Flying", "Ice", "Poison" }, Weaknesses = new List<string> { "Grass", "Electric", "Fighting", "Ground" } },
            new Pokemon { Name = "Omastar", Type = "Rock", Type2 = "Water", Strengths = new List<string> { "Fire", "Flying", "Ice", "Poison" }, Weaknesses = new List<string> { "Grass", "Electric", "Fighting", "Ground" } },
            new Pokemon { Name = "Kabuto", Type = "Rock", Type2 = "Water", Strengths = new List<string> { "Fire", "Flying", "Ice", "Poison" }, Weaknesses = new List<string> { "Grass", "Electric", "Fighting", "Ground" } },
            new Pokemon { Name = "Kabutops", Type = "Rock", Type2 = "Water", Strengths = new List<string> { "Fire", "Flying", "Ice", "Poison" }, Weaknesses = new List<string> { "Grass", "Electric", "Fighting", "Ground" } },
            new Pokemon { Name = "Aerodactyl", Type = "Rock", Type2 = "Flying", Strengths = new List<string> { "Fire", "Bug", "Flying", "Grass" }, Weaknesses = new List<string> { "Water", "Electric", "Ice" } },
            new Pokemon { Name = "Snorlax", Type = "Normal", Type2 = "None", Strengths = new List<string>(), Weaknesses = new List<string> { "Fighting" } },
            new Pokemon { Name = "Articuno", Type = "Ice", Type2 = "Flying", Strengths = new List<string> { "Grass", "Flying", "Dragon", "Bug" }, Weaknesses = new List<string> { "Rock", "Electric", "Steel", "Fire" } },
            new Pokemon { Name = "Zapdos", Type = "Electric", Type2 = "Flying", Strengths = new List<string> { "Flying", "Water", "Grass", "Bug" }, Weaknesses = new List<string> { "Rock", "Ice" } },
            new Pokemon { Name = "Moltres", Type = "Fire", Type2 = "Flying", Strengths = new List<string> { "Grass", "Bug", "Ice", "Steel" }, Weaknesses = new List<string> { "Rock", "Electric", "Water" } },
            new Pokemon { Name = "Dratini", Type = "Dragon", Type2 = "None", Strengths = new List<string> { "Fire", "Water", "Grass", "Electric" }, Weaknesses = new List<string> { "Ice", "Dragon", "Fairy" } },
            new Pokemon { Name = "Dragonair", Type = "Dragon", Type2 = "None", Strengths = new List<string> { "Fire", "Water", "Grass", "Electric" }, Weaknesses = new List<string> { "Ice", "Dragon", "Fairy" } },
            new Pokemon { Name = "Dragonite", Type = "Dragon", Type2 = "Flying", Strengths = new List<string> { "Fire", "Water", "Grass", "Electric", "Bug" }, Weaknesses = new List<string> { "Ice", "Dragon", "Fairy", "Rock" } },
            new Pokemon { Name = "Mewtwo", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } },
            new Pokemon { Name = "Mew", Type = "Psychic", Type2 = "None", Strengths = new List<string> { "Fighting", "Poison" }, Weaknesses = new List<string> { "Bug", "Ghost", "Dark" } }

     
    };


        // Dictionary storing Pokémon ID and names
        private static readonly Dictionary<int, string> Pokemons = new Dictionary<int, string>
  {
            { 1, "Bulbasaur" },
            { 2, "Ivysaur" },
            { 3, "Venusaur" },
            { 4, "Charmander" },
            { 5, "Charmeleon" },
            { 6, "Charizard" },
            { 7, "Squirtle" },
            { 8, "Wartortle" },
            { 9, "Blastoise" },
            { 10, "Caterpie" },
            { 11, "Metapod" },
            { 12, "Butterfree" },
            { 13, "Weedle" },
            { 14, "Kakuna" },
            { 15, "Beedrill" },
            { 16, "Pidgey" },
            { 17, "Pidgeotto" },
            { 18, "Pidgeot" },
            { 19, "Rattata" },
            { 20, "Raticate" },
            { 21, "Spearow" },
            { 22, "Fearow" },
            { 23, "Ekans" },
            { 24, "Arbok" },
            { 25, "Pikachu" },
            { 26, "Raichu" },
            { 27, "Sandshrew" },
            { 28, "Sandslash" },
            { 29, "Nidoran♀" },
            { 30, "Nidorina" },
            { 31, "Nidoqueen" },
            { 32, "Nidoran♂" },
            { 33, "Nidorino" },
            { 34, "Nidoking" },
            { 35, "Clefairy" },
            { 36, "Clefable" },
            { 37, "Vulpix" },
            { 38, "Ninetales" },
            { 39, "Jigglypuff" },
            { 40, "Wigglytuff" },
            { 41, "Zubat" },
            { 42, "Golbat" },
            { 43, "Oddish" },
            { 44, "Gloom" },
            { 45, "Vileplume" },
            { 46, "Paras" },
            { 47, "Parasect" },
            { 48, "Venonat" },
            { 49, "Venomoth" },
            { 50, "Diglett" },
            { 51, "Dugtrio" },
            { 52, "Meowth" },
            { 53, "Persian" },
            { 54, "Psyduck" },
            { 55, "Golduck" },
            { 56, "Mankey" },
            { 57, "Primeape" },
            { 58, "Growlithe" },
            { 59, "Arcanine" },
            { 60, "Poliwag" },
            { 61, "Poliwhirl" },
            { 62, "Poliwrath" },
            { 63, "Abra" },
            { 64, "Kadabra" },
            { 65, "Alakazam" },
            { 66, "Machop" },
            { 67, "Machoke" },
            { 68, "Machamp" },
            { 69, "Bellsprout" },
            { 70, "Weepinbell" },
            { 71, "Victreebel" },
            { 72, "Tentacool" },
            { 73, "Tentacruel" },
            { 74, "Geodude" },
            { 75, "Graveler" },
            { 76, "Golem" },
            { 77, "Ponyta" },
            { 78, "Rapidash" },
            { 79, "Slowpoke" },
            { 80, "Slowbro" },
            { 81, "Magnemite" },
            { 82, "Magneton" },
            { 83, "Farfetch’d" },
            { 84, "Doduo" },
            { 85, "Dodrio" },
            { 86, "Seel" },
            { 87, "Dewgong" },
            { 88, "Grimer" },
            { 89, "Muk" },
            { 90, "Shellder" },
            { 91, "Cloyster" },
            { 92, "Gastly" },
            { 93, "Haunter" },
            { 94, "Gengar" },
            { 95, "Onix" },
            { 96, "Drowzee" },
            { 97, "Hypno" },
            { 98, "Krabby" },
            { 99, "Kingler" },
            { 100, "Voltorb" },
            { 101, "Electrode" },
            { 102, "Exeggcute" },
            { 103, "Exeggutor" },
            { 104, "Cubone" },
            { 105, "Marowak" },
            { 106, "Hitmonlee" },
            { 107, "Hitmonchan" },
            { 108, "Lickitung" },
            { 109, "Koffing" },
            { 110, "Weezing" },
            { 111, "Rhyhorn" },
            { 112, "Rhydon" },
            { 113, "Chansey" },
            { 114, "Tangela" },
            { 115, "Kangaskhan" },
            { 116, "Horsea" },
            { 117, "Seadra" },
            { 118, "Goldeen" },
            { 119, "Seaking" },
            { 120, "Staryu" },
            { 121, "Starmie" },
            { 122, "Mr. Mime" },
            { 123, "Scyther" },
            { 124, "Jynx" },
            { 125, "Electabuzz" },
            { 126, "Magmar" },
            { 127, "Pinsir" },
            { 128, "Tauros" },
            { 129, "Magikarp" },
            { 130, "Gyarados" },
            { 131, "Lapras" },
            { 132, "Ditto" },
            { 133, "Eevee" },
            { 134, "Vaporeon" },
            { 135, "Jolteon" },
            { 136, "Flareon" },
            { 137, "Porygon" },
            { 138, "Omanyte" },
            { 139, "Omastar" },
            { 140, "Kabuto" },
            { 141, "Kabutops" },
            { 142, "Aerodactyl" },
            { 143, "Snorlax" },
            { 144, "Articuno" },
            { 145, "Zapdos" },
            { 146, "Moltres" },
            { 147, "Dratini" },
            { 148, "Dragonair" },
            { 149, "Dragonite" },
            { 150, "Mewtwo" },
            { 151, "Mew" }
        };

        // Method to get a Pokémon name by ID
        public static string GetPokemonById(int id)
        {
            return Pokemons.ContainsKey(id) ? Pokemons[id] : "Unknown Pokémon";
        }

        // Method to get a random Pokémon
        public static (int, string) GetRandomPokemon()
        {
            Random random = new Random();
            int randomId = random.Next(1, Pokemons.Count + 1);
            return (randomId, Pokemons[randomId]);
        }

        // Method to return all Pokémon as a list
        public static List<(int, string)> GetAllPokemons()
        {
            var allPokemons = new List<(int, string)>();
            foreach (var entry in Pokemons)
            {
                allPokemons.Add((entry.Key, entry.Value));
            }
            return allPokemons;
        }

        
        // Method to get a starter Pokémon by ID
        public static string GetStarterPokemonById(int id)
        {
            return StarterPokemons.ContainsKey(id) ? StarterPokemons[id] : "Unknown Starter";
        }

        // Method to get all starter Pokémon
        public static Dictionary<int, string> GetAllStarterPokemons()
        {
            return new Dictionary<int, string>(StarterPokemons);
        }

        public static List<Pokemon> GetAllPokemonByType(string type)
        {
            return AllPokemon.Where(p => p.Type == type).ToList();
        }

    }

}

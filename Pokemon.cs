using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int MagicAttack { get; set; }
        public int Defense { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public string Type { get; set; }
        public string Type2 { get; set; }
        public List<string> Strengths { get; set; }
        public List<string> Weaknesses { get; set; }
        public bool Fainted { get; set; }
        public string Position { get; set; }
        public int TrainingPoints { get; set; } = 10;

        public Move StandardAttack { get; set; }
        public Move ChaseAttack { get; set; }
        public Move MysteryAttack { get; set; }
        public Move PassiveMove { get; set; }

        public int ChaseTriggersLeft { get; set; } = 1; // Default 1 trigger per round

        public Pokemon()
        {
            // Initialize stats without calling LevelUp
            HP = 80;
            Attack = 5;
            MagicAttack = 5;
            Defense = 5;
            SpecialDefense = 5;
            Speed = 5;
            Level = 1;
            TrainingPoints = 10; // Starting training points
        }

        public void LevelUp()
        {
            Level++;
            TrainingPoints += 10; // Gain 10 training points per level

            // HP Level-Up Formula
            var random = new Random();
            int hpIncrease = random.Next(5, (int)(10 + (Defense + SpecialDefense) / (double)Level));
            HP += hpIncrease;

            Console.WriteLine($"{Name} leveled up to Level {Level} and gained 10 training points!");
            Console.WriteLine($"{Name}'s HP increased by {hpIncrease} to {HP}!");
        }

        public void InitializeStats()
        {
            // Base stats for Level 1 Pokémon
            HP = 80;
            Attack = 5;
            MagicAttack = 5;
            Defense = 5;
            SpecialDefense = 5;
            Speed = 5;
            Level = 1;
        }
    }

    public class Move
    {
        public string Name { get; set; } // Name of the move
        public int Power { get; set; } // Base power of the move
        public string Type { get; set; } // Move type (e.g., Grass, Fire)
        public bool IsPhysical { get; set; } // True for Physical moves, False for Special moves
        public string Trigger { get; set; } // Chase trigger condition (only for chase moves)
        public string Effect { get; set; } // Describes additional effects of the move
        public string Cause { get; set; } // The condition or status this move causes
        public int Cost { get; set; } // Energy cost (only for Mystery moves)
        public int Repeats { get; set; } // Number of times a Chase move can repeat per round
    }






}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleText
{
    public class Battle
    {
        private List<Pokemon> PlayerTeam { get; set; }
        private List<Pokemon> OpponentTeam { get; set; }
        private int CurrentCombo { get; set; }

        public Battle(List<Pokemon> playerTeam, List<Pokemon> opponentTeam)
        {
            PlayerTeam = playerTeam;
            OpponentTeam = opponentTeam;
            CurrentCombo = 0;
        }

        public void StartBattle()
        {
            bool battleOngoing = true;

            while (battleOngoing)
            {
                Console.WriteLine("\nBattle Turn!");

                // Player's turn
                foreach (var pokemon in PlayerTeam.Where(p => !p.Fainted))
                {
                    ExecuteAttack(pokemon, OpponentTeam);
                }

                // Opponent's turn
                foreach (var pokemon in OpponentTeam.Where(p => !p.Fainted))
                {
                    ExecuteAttack(pokemon, PlayerTeam);
                }

                // Check win/loss conditions
                if (PlayerTeam.All(p => p.Fainted))
                {
                    Console.WriteLine("You lost the battle!");
                    battleOngoing = false;
                }
                else if (OpponentTeam.All(p => p.Fainted))
                {
                    Console.WriteLine("You won the battle!");
                    battleOngoing = false;
                }
            }
        }

        private void ExecuteAttack(Pokemon attacker, List<Pokemon> targetTeam)
        {
            if (attacker.Fainted) return;

            Console.WriteLine($"{attacker.Name} is attacking!");

            // Standard Attack
            var target = targetTeam.FirstOrDefault(p => !p.Fainted); // Default to position 1
            if (target != null)
            {
                Console.WriteLine($"{attacker.Name} used {attacker.StandardAttack.Name} on {target.Name}!");
                target.HP -= attacker.StandardAttack.Power;
                Console.WriteLine($"{target.Name} has {target.HP} HP left.");

                // Check for fainted Pokémon
                if (target.HP <= 0)
                {
                    target.Fainted = true;
                    Console.WriteLine($"{target.Name} fainted!");
                }

                // Handle Chase Attacks
                if (CurrentCombo >= 10 && attacker.ChaseAttack != null && attacker.ChaseTriggersLeft > 0)
                {
                    Console.WriteLine($"{attacker.Name} triggered {attacker.ChaseAttack.Name}!");
                    target.HP -= attacker.ChaseAttack.Power;
                    attacker.ChaseTriggersLeft--;

                    Console.WriteLine($"{target.Name} has {target.HP} HP left.");
                    if (target.HP <= 0) target.Fainted = true;
                }

                // Reset combo for next turn
                CurrentCombo = 0;
            }
        }
    }

}

using System;

namespace EldoriaChronicles
{
    public class BattleSystem
    {
        private Character player;
        private Enemy enemy;

        public BattleSystem(Character player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public void StartBattle()
        {
            Console.WriteLine($"Pertarungan dimulai: {player.Name} vs {enemy.Name}");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"{player.Name} menyerang {enemy.Name}!");
                enemy.Health -= player.AttackPower;
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name} telah dikalahkan!");
                    break;
                }

                Console.WriteLine($"{enemy.Name} menyerang {player.Name}!");
                player.Health -= enemy.AttackPower;
                if (player.Health <= 0)
                {
                    Console.WriteLine($"{player.Name} telah dikalahkan...");
                    break;
                }
            }
        }
    }
}

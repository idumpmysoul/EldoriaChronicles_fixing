using System;

namespace EldoriaChronicles
{
    public class StartGame
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Permainan dimulai...");
            Character player = new Character("Hero", 100, 10, 5);
            Enemy enemy = new Enemy("Goblin", 50, 8);

            BattleSystem battle = new BattleSystem(player, enemy);
            battle.StartBattle();

            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

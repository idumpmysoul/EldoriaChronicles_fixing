namespace EldoriaChronicles
{
    public class StartGame
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Permainan dimulai...");
            Character player = new Character("Hero", 100, 10, 1);
            Enemy enemy = new Enemy("Goblin", 50, 8);
            LevelUpSystem levelUpSystem = new LevelUpSystem();
            Inventory inventory = new Inventory();

            BattleSystem battle = new BattleSystem(player, enemy);
            battle.StartBattle();

            // Menggunakan level up setelah pertarungan
            levelUpSystem.LevelUp(player, 150); // Misalnya mendapatkan 150 XP dari pertarungan

            // Menggunakan item dari inventory
            inventory.Display();

            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

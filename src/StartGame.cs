using EldoriaChronicles; // Menambahkan import namespace

public class StartGame
{
    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Permainan dimulai...");

        // Membuat karakter pemain dan meminta input nama
        Console.WriteLine("Masukkan nama karakter Anda: ");
        string playerName = Console.ReadLine();
        Character player = new Character(playerName ?? "Hero", 100, 10, 1); // Menambahkan fallback untuk null

        // Daftar musuh yang tersedia
        List<Enemy> enemies = new List<Enemy>
        {
            new Goblin(),
            new Dragon(),
        };

        // Memilih musuh secara acak
        Random rand = new Random();
        Enemy enemy = enemies[rand.Next(enemies.Count)];

        // Menampilkan nama musuh yang dipilih
        Console.WriteLine($"Musuh yang muncul: {enemy.Name}");

        // Sistem battle
        BattleSystem battle = new BattleSystem(player, enemy);
        battle.StartBattle();
    }
}

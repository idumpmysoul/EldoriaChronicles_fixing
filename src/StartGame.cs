using EldoriaChronicles; // Menambahkan import namespace

public class StartGame
{
    public void Execute()
    {
        bool IsContinue = true;
        bool IsBattle = true;
        Random rand = new Random();
        Console.Clear();
        Console.WriteLine("Permainan dimulai...");
        // Membuat karakter pemain dan meminta input nama
        Console.WriteLine("Masukkan nama karakter Anda: ");
        string playerName = Console.ReadLine();
        Character player = new Character(playerName ?? "Hero", 100, 10, 1); // Menambahkan fallback untuk null
        LevelUpSystem levelUpSystem = new LevelUpSystem();
        Inventory inventory = new Inventory();

        while (IsContinue)
        {
            Console.WriteLine($"Hello player {player.Name}");
            Console.WriteLine("You're Currently in Lobby");
            Console.WriteLine("1. Head to the Battle");
            Console.WriteLine("2. Show Character Status");
            //Console.WriteLine("3. Show Inventory");
            Console.WriteLine("0. End Journey");
            Console.Write("Your choice : ");
            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    IsBattle = true;
                    while (IsBattle)
                    {
                        Enemy enemy = rand.Next(3) switch
                        {
                            0 => new Goblin(),
                            1 => new Goblin(),
                            _ => new Dragon()
                        };
                        BattleSystem battle = new BattleSystem(player, enemy);
                        battle.StartBattle();

                        if (enemy.Health <= 0)
                        {
                            levelUpSystem.LevelUp(player, enemy.ExpValue);
                        }

                        Console.WriteLine("Apakah kamu ingin melanjutkan pertarungan?");
                        Console.WriteLine("1. Lanjut");
                        Console.WriteLine("2. Kembali ke Lobby");

                        int valid = 0;
                        do
                        {
                            var action2 = Console.ReadLine();
                            if (action2 == "1")
                            {
                                Console.WriteLine("Menuju medan perang!");
                                IsBattle = true;
                                valid = 1;
                                break;
                            }
                            else if (action2 == "2")
                            {
                                Console.WriteLine("Kembali ke lobby");
                                IsBattle = false;
                                valid = 1;
                                break;
                            }
                            else {
                                Console.WriteLine("Choice Invalid!");
                                valid = 0;
                            }
                        } while (valid == 0);
                    }
                    break;
                case "2":
                    player.Display();
                    break;
                /*
                case "3":
                    inventory.Display();
                    break;
                */
                case "0":
                    Console.WriteLine("Perjalanan yang menyenangkan Hero!");
                    Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
                    Console.ReadLine();
                    IsContinue = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.Clear();
        }
    }

}

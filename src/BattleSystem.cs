using EldoriaChronicles; // Tambahkan ini

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
            Console.WriteLine($"Giliran {player.Name}: ");
            Console.WriteLine("1. Serang biasa");
            Console.WriteLine("2. Gunakan Potion");
            Console.WriteLine("3. Lari");
            Console.WriteLine("Pilih aksi: ");
            var action = Console.ReadLine();

            if (action == "1")
            {
                Attack(player, enemy);
                BattleAnimation();
            }
            else if (action == "2")
            {
                player.UsePotion();
                BattleAnimation();
            }
            else if (action == "3")
            {
                EscapeBattle();
                break;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
                continue;
            }

            if (enemy.Health > 0)
            {
                // Enemy uses special attack
                if (enemy is Dragon dragon && dragon.Health <= 50)
                {
                    dragon.SpecialAttack(player); // Dragon's special attack when it's hurt
                }
                else
                {
                    // Regular or special attack depending on type of enemy
                    if (enemy is Goblin goblin)
                        goblin.SpecialAttack(player);  // Goblin may dodge or attack
                    else
                        enemy.Attack(player); // Default behavior for other enemies
                }

                BattleAnimation();
            }
            if (enemy.Health < 0) {
                enemy.Health = 0;
            }
            else if (player.Health < 0){
                player.Health = 0;
            }

            DisplayStatus();
        }

        // End game messages
        if (player.Health <= 0)
            Console.WriteLine($"{player.Name} telah dikalahkan...");
        else if (enemy.Health <= 0)
            Console.WriteLine($"{enemy.Name} telah dikalahkan!");
    }

    private void Attack(Character attacker, Enemy target)
    {
        Console.WriteLine($"{attacker.Name} menyerang {target.Name} dengan kekuatan {attacker.AttackPower}!");
        target.Health -= attacker.AttackPower;
    }

    private void DisplayStatus()
    {
        Console.WriteLine($"{player.Name}: HP = {player.Health}, AttackPower = {player.AttackPower}");
        Console.WriteLine($"{enemy.Name}: HP = {enemy.Health}, AttackPower = {enemy.AttackPower}");
    }

    private void BattleAnimation()
    {
        Console.WriteLine("Pertempuran sedang berlangsung...");
        Thread.Sleep(1500); // Delay for 1.5 seconds
    }

    private void EscapeBattle()
    {
        Console.WriteLine($"{player.Name} memutuskan untuk kabur dari pertarungan! Health -5");
        player.Health -= 5;  // Player loses health when escaping, or you could make this more complex
    }
}

namespace EldoriaChronicles
{
    public class Dragon : Enemy
    {
        public Dragon() : base("Dragon", 200, 25, 100)
        {
        }

        public override void SpecialAttack(Character player)
        {
            Console.WriteLine($"{Name} menggunakan serangan api besar kepada {player.Name}!");
            player.Health -= AttackPower * 2; // Damage area attack, bigger than normal attack
            Console.WriteLine($"{player.Name} terkena serangan api! Kehilangan {AttackPower * 2} HP!");
        }

        // Overriding to make Dragon stronger as it loses health
        public override void Attack(Character player)
        {
            if (Health <= 50) // If health is low, Dragon gets more aggressive
            {
                AttackPower += 5;
                Console.WriteLine($"{Name} menjadi lebih kuat karena terluka! Serangan bertambah.");
            }
            base.Attack(player);
        }
    }
}
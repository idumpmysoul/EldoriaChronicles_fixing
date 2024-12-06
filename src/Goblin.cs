namespace EldoriaChronicles
{
    public class Goblin : Enemy
    {
        private Random random = new Random();

        public Goblin(string name, int health, int attackPower) : base(name, health, attackPower)
        {
        }

        public override void SpecialAttack(Character player)
        {
            int dodgeChance = random.Next(1, 101); // Chance to dodge attack
            if (dodgeChance <= 20) // 20% chance to dodge
            {
                Console.WriteLine($"{Name} berhasil menghindari serangan {player.Name}!");
            }
            else
            {
                base.SpecialAttack(player);
            }
        }
    }
}

namespace EldoriaChronicles
{
    public class Necromancer : Enemy
    {
        public Necromancer(string name, int health, int attackPower) : base(name, health, attackPower)
        {
        }

        public override void SpecialAttack(Character player)
        {
            // Necromancer summons a minion if defeated
            Console.WriteLine($"{Name} mengutuk {player.Name}, mengurangi kekuatan serangannya!");
            player.AttackPower -= 5; // Reduces player's attack power for the rest of the battle
            Console.WriteLine($"{player.Name}'s serangan berkurang!");
        }

        public void SummonMinion()
        {
            // Summon a minion to fight after the Necromancer dies (just an example)
            Console.WriteLine($"{Name} memanggil minion untuk membantu!");
            // Code for summoning minions could be implemented here
        }
    }
}

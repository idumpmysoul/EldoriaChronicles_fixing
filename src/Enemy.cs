namespace EldoriaChronicles
{
   public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Enemy(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        // Menandai metode SpecialAttack dengan virtual untuk memungkinkan override
        public virtual void SpecialAttack(Character target)
        {
            // Implementasi dasar untuk serangan khusus
            Console.WriteLine($"{Name} melakukan serangan khusus!");
        }

        // Menandai metode Attack dengan virtual untuk memungkinkan override
        public virtual void Attack(Character target)
        {
            // Implementasi dasar untuk serangan biasa
            Console.WriteLine($"{Name} menyerang {target.Name}!");
            target.Health -= AttackPower;  // Serangan dasar mengurangi health target
        }
    }
}
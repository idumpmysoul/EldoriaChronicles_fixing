namespace EldoriaChronicles
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Level { get; set; }

        public Character(string name, int health, int attackPower, int level)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Level = level;
        }
    }
}

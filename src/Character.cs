
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Level { get; set; }
        public bool IsPotionUsed { get; private set; } // Indicate if potion has been used.
        public int ExperiencePoints { get; set; }
        public Character(string name, int health, int attackPower, int level)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Level = level;
            IsPotionUsed = false;
        }

        // Method to use potion
        public void UsePotion()
        {
            if (!IsPotionUsed)
            {
                Health += 20;  // Example, heal 20 HP
                AttackPower += 5; // Boost AttackPower temporarily
                IsPotionUsed = true;
                Console.WriteLine($"{Name} menggunakan potion! Kesehatan meningkat dan serangan lebih kuat!");
            }
            else
            {
                Console.WriteLine($"{Name} sudah menggunakan potion dalam pertarungan ini!");
            }
        }
    }


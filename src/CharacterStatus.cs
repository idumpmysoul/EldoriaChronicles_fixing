using System;

namespace EldoriaChronicles
{
    public class CharacterStatus
    {
        private Character character;

        public CharacterStatus()
        {
            // Buat karakter default
            character = new Character("Hero", 100, 10, 5);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Status Karakter:");
            Console.WriteLine($"Nama: {character.Name}");
            Console.WriteLine($"Health: {character.Health}");
            Console.WriteLine($"Level: {character.Level}");
            Console.WriteLine($"Attack Power: {character.AttackPower}");
            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

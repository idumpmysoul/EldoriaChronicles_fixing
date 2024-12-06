namespace EldoriaChronicles
{
    public class LevelUpSystem
    {
        public void LevelUp(Character character, int experiencePoints)
        {
            // Jika karakter mencapai experience yang cukup, naik level
            character.Level += experiencePoints / 100;  // Menambah level setiap 100 experience

            // Efek dari naik level: menambah health dan attack power
            character.Health += character.Level * 10; // Tambah health setiap naik level
            character.AttackPower += character.Level * 2; // Tambah attack power setiap naik level

            Console.WriteLine($"{character.Name} naik level ke {character.Level}!");
        }
    }
}

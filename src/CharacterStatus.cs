using System;

namespace EldoriaChronicles
{
    public class CharacterStatus
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Status Karakter: (fitur ini dalam pengembangan)");
            Console.WriteLine("Nama: [Nama Karakter]");
            Console.WriteLine("Health: [Health]");
            Console.WriteLine("Level: [Level]");
            Console.WriteLine("Attack Power: [Attack Power]");
            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

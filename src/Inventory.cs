using System;

namespace EldoriaChronicles
{
    public class Inventory
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Inventori:");
            Console.WriteLine("1. Potion Penyembuhan");
            Console.WriteLine("2. Potion Kekuatan");
            Console.WriteLine("Pilih potion untuk digunakan (1-2):");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Anda menggunakan Potion Penyembuhan. Health bertambah 20.");
                    // Tambahkan efek penyembuhan di sini
                    break;
                case "2":
                    Console.WriteLine("Anda menggunakan Potion Kekuatan. Attack Power bertambah 5.");
                    // Tambahkan efek kekuatan di sini
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

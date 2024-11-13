using System;

namespace EldoriaChronicles
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Eldoria Chronicles ===");
                Console.WriteLine("1. Mulai Permainan");
                Console.WriteLine("2. Lihat Status Karakter");
                Console.WriteLine("3. Inventori");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilih opsi (1-4): ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        ShowCharacterStatus();
                        break;
                    case "3":
                        ShowInventory();
                        break;
                    case "4":
                        Console.WriteLine("Terima kasih telah bermain! Sampai jumpa.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Tekan Enter untuk mencoba lagi.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Permainan dimulai... (fitur ini dalam pengembangan)");
            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }

        static void ShowCharacterStatus()
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

        static void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("Inventori: (fitur ini dalam pengembangan)");
            Console.WriteLine("1. Potion Penyembuhan");
            Console.WriteLine("2. Potion Kekuatan");
            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }
    }
}

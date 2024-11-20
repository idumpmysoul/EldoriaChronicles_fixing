
using System;

namespace EldoriaChronicles
{
    public class MainMenu
    {
        private bool exit = false;

        public void Display()
        {
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
                        StartGame startGame = new StartGame();
                        startGame.Execute();
                        break;
                    case "2":
                        CharacterStatus characterStatus = new CharacterStatus();
                        characterStatus.Display();
                        break;
                    case "3":
                        Inventory inventory = new Inventory();
                        inventory.Display();
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
    }
}

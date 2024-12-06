using System;

namespace EldoriaChronicles
{
    public class MainMenu
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Selamat datang di Eldoria Chronicles!");
            Console.WriteLine("1. Mulai Petualangan");
            Console.WriteLine("2. Keluar");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartGame startGame = new StartGame();
                    startGame.Execute();
                    break;
                case "2":
                    Console.WriteLine("Terima kasih telah bermain! Sampai jumpa lagi.");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih lagi.");
                    Display();
                    break;
            }
        }
    }
}

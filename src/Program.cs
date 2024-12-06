using System;

namespace EldoriaChronicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();  // Membuat instance MainMenu
            mainMenu.Display();  // Memanggil method Display untuk menampilkan menu
        }
    }
}

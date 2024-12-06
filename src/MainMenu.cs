using System;


    public class MainMenu
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Selamat datang di Eldoria Chronicles!");
            StartGame startGame = new StartGame();
            startGame.Execute();
        }
    }


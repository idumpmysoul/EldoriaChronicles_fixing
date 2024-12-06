using System;
using System.Collections.Generic;

namespace EldoriaChronicles
{
    public class Item
    {
        public string Name { get; set; }
        public Action<Character> Effect { get; set; }

        public Item(string name, Action<Character> effect)
        {
            Name = name;
            Effect = effect;
        }
    }

    public class Inventory
    {
        private Dictionary<int, Item> items = new Dictionary<int, Item>();

        public Inventory()
        {
            // Menambahkan item ke dalam inventory
            items.Add(1, new Item("Potion Penyembuhan", UseHealingPotion));
            items.Add(2, new Item("Potion Kekuatan", UseStrengthPotion));
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Inventori:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}. {item.Value.Name}");
            }
            Console.WriteLine("Pilih potion untuk digunakan:");

            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int selectedItem) && items.ContainsKey(selectedItem))
            {
                items[selectedItem].Effect?.Invoke(null); // Apply effect to the player
                Console.WriteLine($"Anda menggunakan {items[selectedItem].Name}");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }

            Console.WriteLine("Tekan Enter untuk kembali ke menu utama.");
            Console.ReadLine();
        }

        private void UseHealingPotion(Character player)
        {
            if (player != null)
            {
                player.Health += 20;
                Console.WriteLine($"Health {player.Name} bertambah 20.");
            }
        }

        private void UseStrengthPotion(Character player)
        {
            if (player != null)
            {
                player.AttackPower += 5;
                Console.WriteLine($"Attack Power {player.Name} bertambah 5.");
            }
        }
    }
}

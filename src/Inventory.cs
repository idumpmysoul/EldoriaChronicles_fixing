using EldoriaChronicles;

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
            // Pastikan player tidak null sebelum memanggil efeknya
            if (selectedItem == 1)
                items[selectedItem].Effect?.Invoke(new Character("Hero", 100, 10, 1));  // Contoh pemanggilan
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

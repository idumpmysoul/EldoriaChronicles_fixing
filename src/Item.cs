using EldoriaChronicles; // Pastikan namespace ini ada jika diperlukan

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

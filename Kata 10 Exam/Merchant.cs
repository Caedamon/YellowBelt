namespace Kata_10_Exam;

public class Merchant : ISpeak, ITrade
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares!");
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s Inventory: {string.Join(", ", Inventory)}");
    }
}
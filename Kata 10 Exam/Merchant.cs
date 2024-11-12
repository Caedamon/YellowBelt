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
        string[] speakOptions = new[]
        {
            $"{Name} says: \"Take a look at my wares! Best quality, best prices!\"",
            $"{Name} winks and says, \"Looking for something special? You’ve come to the right place!\"",
            $"{Name} calls out: \"I’ve got what you need, traveler! Have a look!\"",
            $"{Name} grins and says, \"Only the finest goods for you, my friend!\"",
            $"{Name} says with a sly smile, \"Ah, I see you’re a person of taste! Browse away!\""
        };
        Console.WriteLine(speakOptions[new Random().Next(speakOptions.Length)]);
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s Inventory: {string.Join(", ", Inventory)}");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item}");
        }
        string[] tradeOptions = new[]
        {
            "Anything catch your eye? Don’t hesitate!",
            "Feel free to choose an item to buy. Quality guaranteed!",
            "See something you like? Go ahead, make an offer!",
            "Take your time. But remember, the best deals don’t last long!",
            "Careful with your choices, but don’t take too long now!"
        };
        Console.WriteLine(tradeOptions[new Random().Next(tradeOptions.Length)]);
    }
}
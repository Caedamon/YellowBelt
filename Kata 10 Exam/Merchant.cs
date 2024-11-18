namespace Kata_10_Exam;

public class Merchant : ISpeak, ITrade
{
    public string Name { get; set; }
    public List<string> Stock { get; set; } // Renamed from Inventory to avoid conflicts

    public Merchant(string name, List<string> stock)
    {
        Name = name;
        Stock = stock;
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

    public void Trade(Player player)
    {
        Console.WriteLine($"{Name} leans forward and says, \"I have a gift for you—a Healing Potion, free of charge! But only if you don’t already have one or if your current potion is not at full potency.\"");

        if (player.Inventory.HasItem("Healing-Potion"))
        {
            if (player.Inventory.GetItemUses("Healing-Potion") < Inventory.DefaultHealingPotionUses)
            {
                MixPotion(player);
            }
            else
            {
                Console.WriteLine($"{Name} chuckles. \"You already have a full Healing Potion. No need for another!\"");
            }
        }
        else
        {
            GiftPotion(player);
        }
    }

    private void GiftPotion(Player player)
    {
        player.Inventory.AddItem("Healing-Potion", Inventory.DefaultHealingPotionUses);

        string[] giftMessages = new[]
        {
            $"{Name} smiles warmly. \"Take this Healing Potion, traveler. It has three uses—use it wisely.\"",
            $"{Name} hands you a Healing Potion. \"A small token to aid you in your journey. It’s good for three uses.\"",
            $"With a generous nod, {Name} gives you a Healing Potion. \"May it serve you well in times of need—three doses should be enough.\""
        };

        Console.WriteLine(giftMessages[new Random().Next(giftMessages.Length)]);
    }

    private void MixPotion(Player player)
    {
        player.Inventory.AddItem("Healing-Potion", Inventory.DefaultHealingPotionUses);

        string[] mixMessages = new[]
        {
            $"{Name} notices your depleted potion and says, \"Let me help you out.\" He mixes it to restore its potency.",
            $"{Name} smiles and says, \"A little top-up for your potion, traveler.\" Your Healing Potion is now fully replenished.",
            $"\"Ah, I see your potion is running low. Here, let me fix that for you,\" {Name} says as he restores your Healing Potion."
        };

        Console.WriteLine(mixMessages[new Random().Next(mixMessages.Length)]);
    }
}

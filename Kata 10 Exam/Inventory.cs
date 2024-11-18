namespace Kata_10_Exam;

public class Inventory
{
    public const int DefaultHealingPotionUses = 3; //added a constant

    private Dictionary<string, int> items;

    public Inventory()
    {
        items = new Dictionary<string, int>();
    }

    public void AddItem(string item, int uses = 1)
    {
        if (items.ContainsKey(item))
        {
            if (items[item] < DefaultHealingPotionUses) // Check if the current uses are less than max
            {
                string[] mixPotionMessages = new[]
                {
                    "You mix the new potion with the old one, refreshing its potency.",
                    "Combining the potions carefully, you create a fully replenished Healing Potion.",
                    "The new potion merges with the old, restoring its full effectiveness.",
                    "You pour the new potion into the old vial, crafting a revitalized Healing Potion."
                };
                Console.WriteLine(mixPotionMessages[new Random().Next(mixPotionMessages.Length)]);

                items[item] = DefaultHealingPotionUses; // Replenish to max uses
                return;
            }
            else
            {
                Console.WriteLine("Your current Healing Potion is already at full potency!");
                return;
            }
        }

        items[item] = uses;

        string[] addMessages = new[]
        {
            $"A new item, {item}, has been added to your collection with {uses} uses!",
            $"You acquired {item}! It’s safely stored in your inventory with {uses} uses.",
            $"{item} has been stashed away in your inventory, ready for use with {uses} uses.",
            $"{item} is now in your inventory, fully stocked with {uses} uses!"
        };

        Console.WriteLine(addMessages[new Random().Next(addMessages.Length)]);
    }

    public bool UseItem(string item)
    {
        if (items.ContainsKey(item))
        {
            if (items[item] > 0)
            {
                items[item]--;
                string[] useMessages = new[]
                {
                    $"{item} used! Remaining uses: {items[item]}.",
                    $"You used the {item}. It now has {items[item]} uses left.",
                    $"One use of the {item} consumed. Only {items[item]} uses remain.",
                    $"{item} is utilized. Remaining uses: {items[item]}."
                };

                Console.WriteLine(useMessages[new Random().Next(useMessages.Length)]);
                if (items[item] == 0)
                {
                    items.Remove(item);
                    string[] removeMessages = new[]
                    {
                        $"The {item} is fully depleted and removed from your inventory.",
                        $"{item} has no uses left and is now gone from your collection.",
                        $"You’ve used up all the {item}s. It’s been removed from your inventory.",
                        $"With no uses remaining, the {item} is discarded from your inventory."
                    };

                    Console.WriteLine(removeMessages[new Random().Next(removeMessages.Length)]);
                }
                return true;
            }
        }

        string[] noItemMessages = new[]
        {
            $"You check your inventory... but there’s no {item} to be found!",
            $"It seems you’re out of {item}s!",
            $"You search for a {item}, but your inventory is empty of such an item.",
            $"No {item} left in your inventory. Better restock soon!"
        };

        Console.WriteLine(noItemMessages[new Random().Next(noItemMessages.Length)]);
        return false;
    }

    public void ViewInventory()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Alas, your inventory is empty! Time to gather supplies.");
        }
        else
        {
            Console.WriteLine("Your inventory contains the following items:");
            foreach (var kvp in items)
            {
                string usesDisplay = kvp.Key == "Healing-Potion" 
                    ? $"{kvp.Value}/{DefaultHealingPotionUses} uses" 
                    : $"{kvp.Value} uses";
            
                Console.WriteLine($"- {kvp.Key}: {usesDisplay}");
            }
        }
    }

    public bool HasItem(string item) => items.ContainsKey(item);

    public int GetItemUses(string item)
    {
        if (items.ContainsKey(item))
        {
            return items[item];
        }
        return 0;
    }
}
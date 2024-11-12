namespace Kata_10_Exam;

public class Inventory
{
    private List<string> items;

    public Inventory()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
        string[] addMessages = new[]
        {
            $"A new item, {item}, has been added to your collection!",
            $"You acquired {item}! It's safely stored in your inventory.",
            $"{item} has been stashed away in your inventory.",
            $"{item} is now in your inventory, ready for use when needed."
        };
        
        Console.WriteLine(addMessages[new Random().Next(addMessages.Length)]);
    }

    public bool RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            string[] removeMessages = new[]
            {
                $"You use the {item}, and it's removed from your inventory.",
                $"{item} has been used up and removed from your collection.",
                $"The {item} is spent and no longer in your inventory.",
                $"With a final use, the {item} is removed from your inventory."
            };

            Console.WriteLine(removeMessages[new Random().Next(removeMessages.Length)]);
            return true;
        }
        else
        {
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
            foreach (string item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }

    public bool HasItem(string item) => items.Contains(item);
}

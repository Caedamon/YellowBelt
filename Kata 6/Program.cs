// Requirements
//     Create an array of five enemy names (e.g., "Goblin", "Orc", "Troll", "Skeleton", "Dragon") and display each name using a loop.
//     Create a list to represent the player’s inventory with three initial items (e.g., "Sword", "Shield", "Potion").
//     Display the list of inventory items using a loop.
//     Add two more items to the inventory (e.g., "Helmet" and "Armor").
//     Remove one item (e.g., "Potion").
//     Display the updated inventory list.
//     Display the count of items in the inventory list after modifications.

class Program
{
    static void Main(string[] args)
    {
        string[] enemies =
        {
            "Goblin",
            "Orc",
            "Troll",
            "Skeleton",
            "Dragon"
        };
        Console.WriteLine("***Enemies***");
        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }
        Console.WriteLine("Any Key to Continue");
        Console.ReadKey();
        Console.Clear();

        List<string> inventory = new List<string>
        {
            "Sword",
            "Shield",
            "Potion"
        };
        Console.WriteLine("***Player Inventory***");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Any Key to Continue");
        Console.ReadKey();
        Console.Clear();

        inventory.Add("Helmet");
        inventory.Add("Armor");
        inventory.Remove("Potion");
        Console.WriteLine("***Inventory Updated***");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nTotal items in Inventory: {inventory.Count}");
    }
}

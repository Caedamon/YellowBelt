﻿// Requirements
//     Create an array of enemy names (e.g., "Goblin", "Orc", "Troll") and display each name using a loop.
//     Create a list of player inventory items (e.g., "Sword", "Shield", "Potion") and display each item in the list using a loop.
//     Add a new item to the inventory list (e.g., "Helmet") and display the updated list.

class Program
{
    static void Main(string[] args)
    {
        string[] enemies =
        {
            "Goblin", 
            "Orc", 
            "Troll"
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
        Console.WriteLine("***Updated Inventory***");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }

    }
}
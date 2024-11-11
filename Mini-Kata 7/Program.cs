// Requirements
//     Define a simple Player class with the following properties:
// Name (string): The player's name.
//     Health (int): The player’s health points.
//     Level (int): The player’s level.
//     Define a simple Enemy class with the following properties:
// Type (string): The type of enemy (e.g., "Goblin").
//     Health (int): The enemy’s health points.
//     Damage (int): The enemy’s attack damage.
//     In the Main method:
// Create an instance of Player, setting initial values for Name, Health, and Level.
//     Create an instance of Enemy, setting initial values for Type, Health, and Damage.
//     Display the properties of both objects in the console.

using Microsoft.VisualBasic;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
}

class Enemy
{
    public string Type { get; set; } //accidently sat this as Name so was wondering why the hell type got a red mark on it xD
    public int Health { get; set; }
    public int Damage { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player()
        {
            Name = "Arin",
            Health = 100,
            Level = 1
        };

        Enemy enemy = new Enemy()
        {
            Type = "Goblin",
            Health = 50,
            Damage = 10
        };
        
        Console.WriteLine("***Player Info***");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Level: {player.Level}");
        Console.WriteLine("");
        
        Console.WriteLine("***Enemy Info***");
        Console.WriteLine($"Type: {enemy.Type}");
        Console.WriteLine($"Health: {enemy.Health}");
        Console.WriteLine($"Damage: {enemy.Damage}");
    }
}
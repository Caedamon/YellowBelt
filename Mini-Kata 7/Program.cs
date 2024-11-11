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

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
}

class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player()
        {
            
        }
    }
}
// Requirements
//     Define four classes: Player, Enemy, NPC, and Merchant.
//     Player:
// Properties: Name (string), Health (int), and Level (int).
//     Method: Attack that takes an enemy name and deals damage.
//     Enemy:
// Properties: Type (string), Health (int), and Damage (int).
//     Method: TakeDamage that reduces health and displays the remaining health.
//     NPC:
// Properties: Name (string) and Dialogue (string).
//     Method: Speak that prints the dialogue.
//     Merchant:
// Properties: Name (string) and Inventory (list of items).
// Method: Trade that displays available items in inventory.

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public void Attack(Enemy enemy, int damage)
    {
        Console.WriteLine($"{Name} attacks {enemy.Type} and deals {damage}");
        enemy.TakeDamage(damage);
    }
}

class Enemy
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining Life is: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} took {damage} damage and died.");
        }
    }
}

class NPC
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}

class Merchant
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s Trade Inventory contains: {string.Join(", ", Inventory)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player
        {
            Name = "Arin",
            Health = 100,
            Level = 1
        };
        
        Enemy enemy = new Enemy
        {
            Type = "Goblin",
            Health = 50,
            Damage = 10
        };
        player.Attack(enemy, 20);
        Console.WriteLine();
        
        NPC npc = new NPC
        {
            Name = "Villager",
            Dialogue = "Welcome to our village!"
        };
        npc.Speak();
        Console.WriteLine();
        
        Merchant merchant = new Merchant
        {
            Name = "Trader",
            Inventory = new List<string> { "Sword", "Shield", "Potion" },
        };
        merchant.Trade();
    }
}

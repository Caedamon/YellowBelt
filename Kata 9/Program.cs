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
        Console.WriteLine($"Filler");
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
            Console.WriteLine($"filler");
        }
        else
        {
            Console.WriteLine($"Filler");
        }
    }
}

class NPC
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public void Speak()
    {
        Console.WriteLine($"Filler");
    }
}

class Merchant
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public void Trade()
    {
        Console.WriteLine($"Filler");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player
        {

        };
        
        Enemy enemy = new Enemy
        {

        };
        
        NPC npc = new NPC
        {

        };
        
        Merchant merchant = new Merchant
        {

        };
    }
}

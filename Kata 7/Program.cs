// Requirements
//     Define a Player class with the following properties and methods:
// Properties:
// Name (string): The player's name.
//     Health (int): The player’s health points.
//     Level (int): The player’s level.
//     Experience (int): The player’s experience points.
//     Methods:
// Attack(int damage): A method that reduces an enemy’s health by a specified damage amount (you can display a message to simulate the attack).
//     GainExperience(int exp): A method that increases the player’s experience by a specified amount and displays a message.
//     Define an Enemy class with the following properties and methods:
// Properties:
// Type (string): The type of enemy (e.g., "Orc").
//     Health (int): The enemy’s health points.
//     Damage (int): The enemy’s attack damage.
//     Methods:
// TakeDamage(int damage): A method that reduces the enemy’s health by a specified damage amount and displays a message if the enemy is defeated (i.e., Health <= 0).
// In the Main method:
// Create instances of Player and Enemy and initialize their properties.
//     Call Attack on the player to attack the enemy.
//     Call TakeDamage on the enemy to reduce its health.
//     Call GainExperience on the player to add experience points.

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public void Attack(Enemy enemy, int damage)
    {
        Console.WriteLine($"{Name} attacks the {enemy.EnemyType} and deals {damage} amount of damage.");
        enemy.TakeDamage(damage);
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gains {exp} Experience. Total Experience Points are now, {Experience}");
    }
}

class Enemy
{
    public string EnemyType { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{EnemyType} takes {damage} amount of damage. Remaining Health: {Health}");
        }
        else
        {
            Console.WriteLine($"{EnemyType} takes {damage} damage and is slain!");
        }
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player
        {
            Name = "Arin",
            Health = 100,
            Level = 1,
            Experience = 0
        };

        Enemy enemy = new Enemy
        {
            EnemyType = "Orc",
            Health = 50,
            Damage = 10
        };
            
        Player.Attack(Enemy, 20);
        player.GainExperience()50);
    }
}
// Requirements
//     Define a method named AttackEnemy that takes two parameters:
// string enemyName: The name of the enemy being attacked.
// int damage: The damage dealt to the enemy.
//     This method should display a message indicating the enemy name and the damage dealt.
//     Define a method named HealPlayer that takes two parameters:
// string playerName: The name of the player being healed.
// int healAmount: The amount of health restored.
//     This method should display a message indicating the player name and health restored.
//     In the Main method, call both AttackEnemy and HealPlayer with example values to demonstrate how parameters work.

class Program
{
    public static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealth {damage} amount of damage!");
    }

    public static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }

    static void Main(string[] args)
    {
        AttackEnemy("Goblin", 20);
        HealPlayer("Arin", 15);
        
        Console.WriteLine("\nAny Key to Quit");
        Console.ReadKey();
    }
}
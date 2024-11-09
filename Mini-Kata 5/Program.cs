// Mini-Kata 5 - Simple Methods
//     Requirements
// Create a method named Attack that takes an int parameter called damage and prints a message showing the damage dealt.
//     Create another method named Heal that takes an int parameter called healAmount and prints a message showing the health restored.
//     In the Main method, call both Attack and Heal with sample values to see the output.

class Program
{
    public static void Attack(int damage)
    {
        Console.WriteLine($"{damage} dealt");
    }

    public static void Heal(int healAmount)
    {
        Console.WriteLine($"{healAmount} healed.");
    }

    static void Main(string[] args)
    {
        Attack(15);
        Heal(10);
        Console.WriteLine("\n Any Key to Exit");
    }
}
namespace Kata_10_Exam;

public class Player : ICombat
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    private const int MaxHealth = 100;

    public Player(string name)
    {
        Name = name;
        Health = MaxHealth;
        Level = 1;
        Experience = 0;
    }

    public void Attack(ICombat target)
    {
        int damage = 20;
        Console.WriteLine($"filler");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Filler");
    }

    public void Heal()
    {
        int healAmount = 15;
        Health = Math.Min(Health + healAmount, MaxHealth);
        Console.WriteLine($"Filler");
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"Filler");
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Experience = 0;
        Level++;
        Console.WriteLine($"Filler");
    }

    public bool IsAlive() => Health > 0;

}
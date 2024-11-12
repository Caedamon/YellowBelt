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
        Console.WriteLine($"{Name} lunges forward and strikes the {((Enemy)target).Type} for {damage} amount of damage.");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        { 
            Console.WriteLine($"{Name} reels from the blow, taking {damage} damage! Health remaining: {Health}");
        }
        else
        {
            Console.WriteLine($"{Name} collapses under the attack, their health reduced to zero. The end may be near...");
        }
    }

    public void Heal()
    {
        int healAmount = 15;
        int previousHealth = Health;
        Health = Math.Min(Health + healAmount, MaxHealth);
        int actualHeal = Health - previousHealth;
        if (actualHeal > 0)
        {
            Console.WriteLine($"{Name} channels a soothing energy, restoring {actualHeal} health! Current Health is now {Health}");
        }
        else
        {
            Console.WriteLine($"{Name} attempts to heal but is already at full strength! Health remains at {Health}/{MaxHealth}.");
        }
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gains {exp} experience point{(exp > 1 ? "s" : "")}! Total Accumulated Experience is now {Experience}");
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Experience = 0;
        Level++;
        Console.WriteLine($"\u2728 Congratulations, {Name}! \u2728 You've reached level {Level}! Your power grows stronger, and new challenges await!");
    }

    public bool IsAlive() => Health > 0;

}
namespace Kata_10_Exam;

public class Player : ICombat
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    private const int MaxHealth = 100;
    public Inventory Inventory { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = MaxHealth;
        Level = 1;
        Experience = 0;
        Inventory = new Inventory();
        Inventory.AddItem("healPotion");
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

    public void UseHealPotion()
    {
        if (Inventory.RemoveItem("healPotion"))
        {
            int healAmount = 20;
            int previousHealth = Health;
            Health = Math.Min(Health + healAmount, MaxHealth);
            int actualHeal = Health - previousHealth;

            string[] healMessages = new[]
            {
                $"{Name} quickly downs a healing potion, restoring {actualHeal} health! Current health: {Health}/{MaxHealth}.",
                $"{Name} drinks a healing potion, feeling energy flow through them! Health restored by {actualHeal}. Now at {Health}/{MaxHealth}.",
                $"{Name} uses a potion, vitality returning with {actualHeal} health restored. Health is now {Health}/{MaxHealth}.",
                $"{Name} gulps down a healing potion, regaining {actualHeal} health! Current health: {Health}/{MaxHealth}."
            };

            Console.WriteLine(healMessages[new Random().Next(healMessages.Length)]);
        }
        else
        {
            string[] noPotionMessages = new[]
            {
                $"{Name} rummages through their inventory... but finds no healing potions left!",
                $"{Name} searches their bag, only to realize they’re out of healing potions!",
                $"{Name} feels for a healing potion but finds nothing. No potions remain!",
                $"{Name} sighs as they realize their supply of healing potions is depleted."
            };

            Console.WriteLine(noPotionMessages[new Random().Next(noPotionMessages.Length)]);
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
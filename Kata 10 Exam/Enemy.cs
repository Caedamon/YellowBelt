namespace Kata_10_Exam;

class Enemy : ICombat
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void Attack(ICombat target)
    {
        Console.WriteLine($"Filler");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"Filler");
        }
        else
        {
            Console.WriteLine("Filler");
        }
    }
    
    public bool IsAlive() => Health > 0;
}
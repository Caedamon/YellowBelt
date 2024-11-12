namespace Kata_10_Exam;

public class Enemy : ICombat
{
    private readonly Random random;
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type, int health, int damage, Random random)
    {
        Type = type;
        Health = health;
        Damage = damage;
        this.random = random;
    }
    
    private void DisplayColoredHealth(int health, int maxHealth)
    {
        double healthPercentage = (double)health / maxHealth * 100;

        if (healthPercentage <= 30)
            Console.ForegroundColor = ConsoleColor.Red;
        else if (healthPercentage >= 70)
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write(health);
        Console.ResetColor();
    }

    public void Attack(ICombat target)
    {
        string[] attackMessages = new[] 
            //the 3 below i asked chatgtp to make for me, i wanted more variety
            //honestly i was going to use if, else if else for this
            //with some new Random rolls for each, but this setup....
            //this is sooo much better!
        {
            $"The {Type} snarls and lunges forward, dealing a brutal {Damage} damage!",
            $"With a menacing growl, the {Type} strikes viciously, inflicting {Damage} damage!",
            $"The {Type} unleashes a fierce attack, slashing for {Damage} damage!",
        };
        Console.WriteLine(attackMessages[random.Next(attackMessages.Length)]);
        DisplayColoredHealth(Health, 30);
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            string[] hurtMessages = new[] //same here
            {
                $"The {Type} staggers, taking {damage} damage! Remaining health: {Health}.",
                $"A furious roar echoes as the {Type} is wounded, losing {damage} health! Health left: {Health}.",
                $"The {Type} recoils from the blow, enduring {damage} damage. Current health: {Health}."
            };
            Console.WriteLine(hurtMessages[random.Next(hurtMessages.Length)]);
        }
        else
        {
            string[] defeatMessages = new[] //and ofcourse, here.
            {
                $"The {Type} collapses with a final roar, defeated and lifeless.",
                $"With one last gasp, the {Type} crumbles to the ground, its strength utterly spent.",
                $"The {Type} lets out a pained cry as it falls, defeated at last."
            };
            Console.WriteLine(defeatMessages[random.Next(defeatMessages.Length)]);
        }
    }
    
    public bool IsAlive() => Health > 0;
}
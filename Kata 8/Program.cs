// Requirements
//     Update the Player class:
// Private Fields: Convert Health, Level, and Experience to private fields.
//     Public Properties: Create public properties for Health, Level, and Experience with appropriate getters and setters.
//     Ensure Health can be accessed but only modified within the class itself.
// Ensure Level and Experience can be set by other classes but have validation in the setter to prevent negative values.
//     Create a private method LevelUp() that increases Level by 1 and resets Experience to 0.
//     Update GainExperience(int exp) to call LevelUp() if Experience reaches or exceeds 100.
//     In the Main method:
// Create a Player instance and call GainExperience to test the level-up logic.
//     Try directly setting Health outside the class to verify encapsulation (this should produce an error if Health is correctly encapsulated).

class Player
{
    private int health;
    private int lvl;
    private int experience;

    public int Health
    {
        get { return health; }
        private set
        {
            if (value >= 0)
                health = value;
        }
    }

    public int Level
    {
        get { return lvl; }
        set
        {
            if (value >= 0)
                lvl = value;
        }
    }

    public int Experience
    {
        get { return experience; }
        set
        {
            if (value >= 0)
                experience = value;
        }
    }

    public Player(string name, int initialHealth)
    {
        Name = name;
        Health = initialHealth;
        Level = 1;
        Experience = 0;
    }
    
    public string Name { get; set; }

    public void GainExperience(int exp)
    {
        if (exp < 0) return;
        Experience += exp;
        Console.WriteLine($"Filler");
        if (Experience >= 100)
        {
            levelUp();
        }
    }

    private void LevelUp();
    {
        Experience = 0;
        Level++;
        Console.WriteLine($"Filler");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Filler");
    }
}

class Program
{
    
    
}

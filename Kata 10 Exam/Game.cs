namespace Kata_10_Exam;

public class Game
{
    private Player player;
    Random random = new Random(); //should fit better here, can be called by all "instances" in my code now

    public Game()
    {
        Console.Write("Enter your name:");
        string playerName = Console.ReadLine();
        player = new Player(playerName);
        Console.WriteLine($"{player.Name} is ready for the adventure!");
        Console.WriteLine("\nPress any key to start your journey!");
        Console.ReadKey();
    }

    public void Start()
    {
        while (player.IsAlive())
        {
            Console.Clear();
            Console.WriteLine($"{player.Name}'s stats:");
            player.DisplayHealth();
            Console.WriteLine($"Level: {player.Level} \nExperience: {player.Experience}");
            int encounter = random.Next(1, 21); //changed this to make it a lower chance of encountering npc and merchant

            switch (encounter)
            {
                case <= 14:
                    EncounterEnemy();
                    break;
                case <= 17:
                    EncounterNPC();
                    break;
                case <= 20:
                    EncounterMerchant();
                    break;
            }
            if (player.IsAlive())
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
        }

        Console.WriteLine("Game Over! You fought bravely!");
    }
    private void EncounterEnemy()
    {
        Enemy enemy = new Enemy("Goblin", 30, 5, random);
        Console.WriteLine($"\nA wild {enemy.Type} appears with {enemy.Health} health, it deals {enemy.Damage} damage per attack!");
        
        while (enemy.IsAlive() && player.IsAlive())
        {
            Console.WriteLine("\nChoose an action!: \n1. Attack! \n2. Heal Yourself");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                player.Attack(enemy);
                if (enemy.IsAlive())
                {
                    enemy.Attack(player);
                }
            }
            else if (choice == "2")
            {
                player.UseHealPotion();
                if (enemy.IsAlive())
                {
                    enemy.Attack(player);
                }
            }
            else if (choice == "3")
            {
                player.Inventory.ViewInventory();
            }
            else
            {
                Console.WriteLine("That is not a valid choice! Try again.");
            }
        }
        if (player.IsAlive())
        {
            Console.WriteLine($"\nYou defeated the {enemy.Type} and gained 30 experience points!");
            player.GainExperience(30);
        }
    }
    private void EncounterNPC()
    {
        NPC npc = new NPC("Villager", $"Welcome to our Village {player.Name}");
        npc.Speak();
    }
    private void EncounterMerchant()
    {
        Merchant merchant = new Merchant("Trader", new List<string>());
        merchant.Speak();
        merchant.Trade(player);
    }
}

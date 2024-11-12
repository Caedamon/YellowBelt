namespace Kata_10_Exam;

public class Game
{
    private Player player;

    public Game()
    {
        Console.Write("Enter your name:");
        string playerName = Console.ReadLine();
        player = new Player(playerName);
        Console.WriteLine($"{player.Name} is ready for the adventure!");
    }

    public void Start()
    {
        Random random = new Random();
        while (player.IsAlive())
        {
            Console.Clear();
            int encounter = random.Next(1, 4);
            if (encounter == 1)
            {
                Enemy enemy = new Enemy("Goblin", 30, 5);
                Console.WriteLine($"\nA wild {enemy.Type} appears with {enemy.Health} health, it deals {enemy.Damage} damage per attack!");

                while (enemy.IsAlive() && player.IsAlive())
                {
                    Console.WriteLine("\nChoose an action!: \n1. Attack! \n2. Heal Yourself");
                    string choise = Console.ReadLine();

                    if (choise == "1")
                    {
                        player.Attack(enemy);
                        if (enemy.IsAlive())
                        {
                            enemy.Attack(player);
                        }
                    }
                    else if (choise == "2")
                    {
                        player.Heal();
                        enemy.Attack(player);
                    }
                }

                if (player.IsAlive())
                {
                    player.GainExperience(30);
                }
            }
            else if (encounter == 2)
            {
                NPC npc = new NPC("Villager", $"Welcome to our Village {player.Name}");
                npc.Speak();
            }
            else if (encounter == 3)
            {
                Merchant merchant = new Merchant("Trader", new List<string> {"Sword", "Shield", "Potion"});
                merchant.Speak();
                merchant.Trade();
            }
            
            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
        }
        
        Console.WriteLine("Game Over! You fought bravely!");
    }
    
}
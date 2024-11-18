namespace Kata_10_Exam;

public class NPC : ISpeak
{
    public string Name { get; set; } //think of dry, how to improve, remove duplications in things like string name
    public string Dialogue { get; set; }

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }
    
    public void Speak()
    {
        string[] dialogueStyles = new[] 
            //i kinda enjoy abusing chatgtp for this xD
            //to be honest, ive got over 25 years of experience as a storyteller, rpg-game master and such
            //so... i could write this in my sleep. i just...
            //i dont want to put down hours ofstory-scripting for a oneshot!
        {
                $"{Name} clears their throat and says, \"{Dialogue}\"",
                $"{Name} leans closer and whispers, \"{Dialogue}\"",
                $"{Name} gestures passionately and exclaims, \"{Dialogue}\"",
                $"{Name} sighs deeply before speaking: \"{Dialogue}\"",
                $"{Name} looks you in the eye and says, \"{Dialogue}\"",
                $"{Name} chuckles softly and remarks, \"{Dialogue}\"",
                $"{Name} speaks in a low, serious tone: \"{Dialogue}\""
        };
        Console.WriteLine(dialogueStyles[new Random().Next(dialogueStyles.Length)]);
    }
}
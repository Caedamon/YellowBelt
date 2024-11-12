namespace Kata_10_Exam;

class NPC : ISpeak
{
    public string Name
    public string Dialogue

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }
    
    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}
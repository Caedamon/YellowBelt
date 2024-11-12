namespace Kata_10_Exam
    
public interface ICombat
{
    void Attack(ICombat target);
    void TakeDamage(int damage);
}

public interface ISpeak
{
    void Speak();
}

public interface ITrade
{
    void Trade();
}
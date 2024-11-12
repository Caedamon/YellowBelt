namespace Kata_10_Exam;

Interface ICombat
{
    void Attack(ICombat target);
    void TakeDamage(int damage);
}

interface ISpeak
{
    void Speak();
}

//Interface ITrade
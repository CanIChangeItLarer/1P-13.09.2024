namespace GhinImp;

// Класс для описания навыков персонажей
public class Skill
{
    public string SkillName;
    public int Damage;
    
    public Skill()
    {
        SkillName = "Unnamed Skill";
        Damage = 0;
    }

    // Метод для расчета урона навыка
    public int CalculateSkillDamage() //int, тк return Damage * 2
    {
        return Damage * 2;
    }
}
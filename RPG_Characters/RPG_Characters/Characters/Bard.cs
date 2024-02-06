namespace RPG_Characters.Characters;

public class Bard:Character
{
    public Bard(String name)
    :base(name, "Bard", "A musical personage")
    {
        _allowedWeapons.Add(WeaponAttackType.Ranged);
        _allowedWeapons.Add(WeaponAttackType.Melee);
        _allowedWeapons.Add(WeaponAttackType.Magic);
    }

    public void PlayEpicMusic()
    {
        Console.WriteLine(" [ MUSIC INTENSIFIES ]");
    }

    public override void PrintDescription()
    {
        Console.WriteLine(_description +": The bard plays a tune");
    }
}
namespace RPG_Characters.Characters;

public class Wizard:Character
{
    public Wizard(String name)
    :base(name,
          "Wizard",
          "a hocus pucus person")
    {
        _allowedWeapons.Add(WeaponAttackType.Magic);
    }
    
    
}
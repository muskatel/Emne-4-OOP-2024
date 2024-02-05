namespace RPG_Characters.Characters;

public class Fighter:Character
{
    public Fighter(String name)
    :base(name,
          "Fighter",
          "a strong fighting person")
    {
        _allowedWeapons.Add(WeaponAttackType.Melee);
    }
    
}
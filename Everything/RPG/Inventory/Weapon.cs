namespace Everything.RPG.Inventory;

public enum WeaponType
{
    Melee,
    Ranged,
    Magic
}

public abstract class Weapon
{
    public WeaponType WeaponType { get; }

    protected Weapon(WeaponType weaponType)
    {
        WeaponType = weaponType;
    }
}
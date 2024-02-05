namespace RPG_Characters;

public class Character
{
    private String _name; // The name of the actual character
    private String _className;
    private String _description;
    private Weapon _equippedWeapon;

    protected List<WeaponAttackType> _allowedWeapons;
    //Collection: List

    public Character(string name, string className, string description)
    {
        _name = name;
        _className = className;
        _description = description;
        _allowedWeapons = new List<WeaponAttackType>();
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (_allowedWeapons.Contains(weapon.AttackType))
        {
            _equippedWeapon = weapon;
        }
        else
        {
            // handle what happens when a character cannot equip a weapon
        }
    }

    public String Attack()
    {
        if (_equippedWeapon == null)
        {
            return $"{_name} the {_className} cant' attack without a weapon";
        }
        return $"{_name} the {_className} makes a {_equippedWeapon.Attack()}";
    }
}
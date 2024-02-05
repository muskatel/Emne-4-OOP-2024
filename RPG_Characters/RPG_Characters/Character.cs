namespace RPG_Characters;

public class Character
{
    private String _name; // The name of the actual character
    private String _className;
    private String _description;
    private Weapon _equippedWeapon;

    public Character(string name, string className, string description)
    {
        _name = name;
        _className = className;
        _description = description;
    }

    public void EquipWeapon(Weapon weapon)
    {
        _equippedWeapon = weapon;
    }

    public String Attack()
    {
        return $"{_name} the {_className} makes a {_equippedWeapon.Attack()}";
    }
}
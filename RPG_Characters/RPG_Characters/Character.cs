namespace RPG_Characters;

public class Character
{
    private String _name;
    private String _description;
    private Weapon _equippedWeapon;

    public Character(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void EquipWeapon(Weapon weapon)
    {
        _equippedWeapon = weapon;
    }

    public String Attack()
    {
        return $"{_name} used a {_equippedWeapon.Attack()}";
    }
}
namespace RPG_Characters.Characters;

public class Ranger:Character
{

    /// <summary>
    /// Creates a new ranger with the name provided
    /// </summary>
    /// <param name="name">The characters name</param>
    public Ranger(String name)
    :base(name,
        "Ranger", 
        "a merry person of the woods")
    {
        _allowedWeapons.Add(WeaponAttackType.Ranged);
    }
    
    public override void PrintDescription()
    {
        Console.WriteLine("Ranger description: " + _description);
    }
    
}
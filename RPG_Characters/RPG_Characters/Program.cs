namespace RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Character char1 = new Character("Craig", "the ranger");
        Weapon w1 = new Weapon("bow", "a fancy bow", WeaponAttackType.Ranged);
        char1.EquipWeapon(w1);
        
        Console.WriteLine(char1.Attack());
        
    }
}
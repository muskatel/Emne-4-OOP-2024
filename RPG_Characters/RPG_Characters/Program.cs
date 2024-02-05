using RPG_Characters.Characters;
using RPG_Characters.Weapons;

namespace RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Character char1 = new Wizard("Craigsworth");

        Weapon wep1 = new Sword();
        
        char1.EquipWeapon(wep1);
        
        Console.WriteLine(char1.Attack());
        
    }
}
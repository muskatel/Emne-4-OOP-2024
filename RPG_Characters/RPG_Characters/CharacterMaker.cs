using System.Diagnostics;
using RPG_Characters.Characters;
using RPG_Characters.Weapons;

namespace RPG_Characters;

public static class CharacterMaker
{
    public static Character RandomCharacter()
    {
        Console.WriteLine("Creating a new random character");
        Random random = new Random();
        
        List<String> start = new List<string>();
        start.Add("Gan");
        start.Add("Ara");
        start.Add("Gim");
        start.Add("Fro");
        start.Add("Sam");
        
        List<String> end = new List<string>();
        end.Add("dalf");
        end.Add("gorn");
        end.Add("li");
        end.Add("do");
        end.Add("wise");
        
        //Create a random name?
        String name = start[random.Next(start.Count)] 
                      + end[random.Next(end.Count)];

        // Add character and weapon options Options
        List<String> characterOptions = new List<string>();
        characterOptions.Add("Fighter");    // 0
        characterOptions.Add("Ranger");     // 1
        characterOptions.Add("Rogue");      // 2
        characterOptions.Add("Wizard");     // 3
        characterOptions.Add("Bard");       // 4

        List<String> weaponOptions = new List<string>();
        weaponOptions.Add("Bow");
        weaponOptions.Add("Staff");
        weaponOptions.Add("Sword");
        
        //Initialize a base character
        Character character = null;
        
        // pick a random class 
        int roll = random.Next(characterOptions.Count);
        //Console.WriteLine($"Rolled a {roll}: {characterOptions[roll]}");
        switch (characterOptions[roll])
        {
            case "Fighter":
                character = new Fighter(name);
                break;
            case "Ranger":
                character = new Ranger(name);
                break;
            case "Rogue":
                character = new Rogue(name);
                break;
            case "Wizard":
                character = new Wizard(name);
                break;
            case "Bard":
                character = new Bard(name);
                break;
        }
        
        //pick a random weapon
        roll = random.Next(weaponOptions.Count);
        switch (weaponOptions[roll])
        {
           case "Bow":
               character.EquipWeapon(new Bow());
               break;
           case "Staff" :
               character.EquipWeapon(new Staff());
               break;
           case "Sword:":
               character.EquipWeapon(new Sword());
               break;
        }
        
        return character;
    }
}
using System.Diagnostics;
using RPG_Characters.Characters;

namespace RPG_Characters;

public static class CharacterMaker
{
    public static Character RandomCharacter()
    {
        Console.WriteLine("Creating a new random character");
        Random random = new Random();
        
        //Create a random name?
        String name = "Bobbington";

        // Add character and weapon options Options
        List<String> characterOptions = new List<string>();
        characterOptions.Add("Fighter");    // 0
        characterOptions.Add("Ranger");     // 1
        characterOptions.Add("Rogue");      // 2
        characterOptions.Add("Wizard");     // 3

        List<String> weaponOptions = new List<string>();
        weaponOptions.Add("Bow");
        weaponOptions.Add("Staff");
        weaponOptions.Add("Sword");
        
        //Initialize a base character
        Character character = null;
        
        // pick a random class 
        int roll = random.Next();
        //Console.WriteLine($"Rolled a {roll}");
        roll = roll % characterOptions.Count;
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
        }
        
        //pick a random weapon
        roll = random.Next();
            
        return character;
    }
}
using RPG_Characters.Characters;
using RPG_Characters.Weapons;

namespace RPG_Characters;

class Program
{
    static void Main(string[] args)
    {
        /*
        // OLD CODE
        // Create a character
        Character player1 = new Wizard("Craigsworth");
        // LSP means that we can choose any class to "fit" into the character role
        
        // Create a weapon
        Weapon wep1 = new Staff();
        // LSP again
        
        // Tell the character to equip the weapon
        player1.EquipWeapon(wep1);
        
        // Attempt an attack
        // Console.WriteLine(player1.Attack());

        Character player2 = new Fighter("Steve");
        player2.EquipWeapon(new Sword());

        */
        
        List<Character> party = new List<Character>();
        
        //party.Add(new Character("CRAIG", "TEACHERMAN", "the best"));
        
        for (int j = 0; j < 5; j++)
        {
           party.Add(CharacterMaker.RandomCharacter()); 
        }

        foreach (Character character in party)
        {
            Console.WriteLine(character.Attack());
            character.PrintDescription();
            Console.WriteLine(" ");
        }
        
        int i = 0;


    }
}
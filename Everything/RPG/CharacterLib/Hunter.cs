using Everything.RPG.Abilities;
using Everything.RPG.Attacks;

namespace Everything.RPG.CharacterLib;

public class Hunter: Character
{
    public Hunter(String name) 
        : base("Hunter", name, new Track(), new PlaceTrap(), new Melee(), new Ranged())
        
    {
        
    }
}
namespace Everything.RPG.CharacterLib;

public abstract class Character
{
    public String CharacterType { get; }
    public String DisplayName { get; }
    
    public IAbility Ability1 { get; }
    public IAbility Ability2 { get; }
    
    public IAttack AttackPrimary { get; }
    public IAttack AttackSecondary { get; }

    protected Character(string characterType, string displayName, IAbility ability1, IAbility ability2, IAttack attackPrimary, IAttack attackSecondary)
    {
        CharacterType = characterType;
        DisplayName = displayName;
        Ability1 = ability1;
        Ability2 = ability2;
        AttackPrimary = attackPrimary;
        AttackSecondary = attackSecondary;
    }
}
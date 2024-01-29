namespace PetsInClass;

public class Fish:Pet
{
    public Fish(string name) 
        : base(name)
    {
        noise = "blub";
        trick = "play dead";
    }

    public override string ToString()
    {
        return "fish";
    }
}
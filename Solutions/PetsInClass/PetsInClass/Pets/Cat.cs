namespace PetsInClass;

public class Cat:Pet
{
    public Cat(string name) 
        : base(name)
    {
        noise = "meow";
        trick = "dominate the world";
    }

    public override string ToString()
    {
        return "cat";
    }
}
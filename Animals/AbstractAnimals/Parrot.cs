namespace AbstractAnimals;

public class Parrot:Animal
{
    public Parrot()
    {
        info = "This is a parrot.";
    }

    public override void makeNoise()
    {
        Console.WriteLine("SQUAK!!!");
    }
}
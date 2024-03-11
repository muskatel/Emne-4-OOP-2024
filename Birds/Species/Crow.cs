using Birds.Interfaces;

namespace Birds.Species;

public class Crow:Bird, IFly, INoise
{
    public void Fly()
    {
        Console.WriteLine("A crow flies");
    }

    public void Noise()
    {
        Console.WriteLine("A crow goes \"CAW\"");
    }

    public Crow():base("Carrion crow", "Corvus corone")
    {
        
    }
}
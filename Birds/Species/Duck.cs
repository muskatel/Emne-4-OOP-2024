using Birds.Interfaces;

namespace Birds.Species;

public class Duck:Bird, IFly, INoise, IFloat
{
    public void Fly()
    {
        Console.WriteLine("A duck flies");
    }

    public void Noise()
    {
        Console.WriteLine("A duck goes \"QUACK\"");
    }

    public void Float()
    {
        Console.WriteLine("A duck floats");
    }

    public Duck():base("Domestic Duck", "Anas domesticus")
    {
        
    }
}
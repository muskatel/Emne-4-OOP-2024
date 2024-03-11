using Birds.Interfaces;

namespace Birds.Species;

public class Penguin:Bird, INoise, IFloat, ISwim
{
    public void Noise()
    {
       Console.WriteLine("A penguin makes some wierd noise");
       // https://www.youtube.com/watch?v=8PZs2LzrpM8
    }

    public void Float()
    {
        Console.WriteLine("A penguin floats");
    }

    public void Swim()
    {
        Console.WriteLine("A penguin swims");
    }

    public Penguin():base("African Penguin", "Spheniscus demersus")
    {
        
    }
}
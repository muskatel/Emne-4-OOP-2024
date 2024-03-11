using Birds.Interfaces;

namespace Birds.Species;

public class Thrush:Bird, IFly
{
    public void Fly()
    {
        Console.WriteLine("A thrush flies");
    }

    public Thrush():base("Common blackbird", "Turdus merula")
    {
        
    }
}
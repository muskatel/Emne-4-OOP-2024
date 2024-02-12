namespace AbstractAnimals;

public class Mouse:Animal
{
    public Mouse()
    {
        info = "This is a mouse.";
    }
    
    public override void makeNoise()
    {
        Console.WriteLine("Squeak"); 
    }

}
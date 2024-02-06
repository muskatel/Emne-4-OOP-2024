namespace AbstractAnimals;

public class Mouse
{
    public String info = "This is a mouse.";

    public Mouse()
    {
        //nothing here
    }
    
    public void makeNoise()
    {
        Console.WriteLine("Squeak"); 
    }

    public void getInfo()
    {
        Console.WriteLine(info);
    }
}
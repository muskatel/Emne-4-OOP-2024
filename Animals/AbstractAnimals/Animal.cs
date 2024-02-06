namespace AbstractAnimals;

public abstract class Animal
{
    protected String info = "INFO NOT SET";
    
    public void getInfo()
    {
        Console.WriteLine(info);
    }

    public abstract void makeNoise();
    // {
    //     throw new Exception("BASE METHOD CALLED");
    // }
}
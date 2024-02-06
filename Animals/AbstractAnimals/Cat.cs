namespace AbstractAnimals;

public class Cat
{
    private String info = "This is a cat.";

    public Cat()
    {
        //nothing here
    }
    
    public void makeNoise()
    {
        Console.WriteLine("Meow"); 
    }

    public void getInfo()
    {
        Console.WriteLine(info);
    }
}
namespace AbstractAnimals;

public class Cat:Animal
{
    public Cat()
    { 
        info = "This is a cat.";
    }
    
    public override void makeNoise()
    {
        Console.WriteLine("Meow"); 
    }

}
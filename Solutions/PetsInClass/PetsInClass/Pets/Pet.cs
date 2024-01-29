namespace PetsInClass;

public class Pet
{
    private String name;
    protected String noise;
    protected String trick;

    public Pet(String name)
    {
        this.name = name;
    }

    public String GetName()
    {
        return name;
    }

    public String GetNoise()
    {
        return noise;
    }

    public String GetTrick()
    {
        return trick;
    }


    /*
    public override string ToString()
    {
        return "pet";
    }
    */
}
using IkeaApp.Interfaces;

namespace IkeaApp.Products;

public class Bookshelf : Product, IAssemblable, IOffice , ILivingRoom
{
    private string AssemblySteps;
    
    public Bookshelf() 
    : base("bookshelf", 800f, "450", "it holds your books")
    {

        AssemblySteps = GetAssemblySteps();
    }

    public override float Price()
    {
        return protected_price;
    }

    public override string GetShelf()
    {
        return protected_shelf;
    }

    public override string Description()
    {
        return protected_shelf;
    }

    public string Office()
    {
        return $"This {protected_name} is great for your office, it is {protected_description}!";

    }

    public string LivingRoom()
    {
        return $"This {protected_name} is great for your living room, it is {protected_description}!";
    }

    public string Assemble()
    {
        return AssemblySteps;
    }

    public string GetAssemblySteps()
    {
        return base.ReadAssemblyStepsFromDB();
    }
}
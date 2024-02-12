using IkeaApp.Interfaces;

namespace IkeaApp.Products;

public class Carpet: Product, ILivingRoom, IOffice, IBedroom
{
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

    public string LivingRoom()
    {
        return $"This {protected_name} is great for your living room, it is {protected_description}!";
    }

    public string Office()
    {
        return $"This {protected_name} is great for your office, it is {protected_description}!";
    }

    public string Bedroom()
    { 
        return $"This {protected_name} is great for your bedroom, it is {protected_description}!";
    }

    public Carpet() 
    : base("carpet", 399f, "330", "a gorgeous carpet")
    {
        
    }
}
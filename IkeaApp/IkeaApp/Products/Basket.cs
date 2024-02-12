using IkeaApp.Interfaces;

namespace IkeaApp.Products;

public class Basket: Product, ILivingRoom, IBedroom
{
    public Basket(string name, float price, string shelf, string description) : base(name, price, shelf, description)
    {
    }

    public override float Price()
    {
        throw new NotImplementedException();
    }

    public override string GetShelf()
    {
        throw new NotImplementedException();
    }

    public override string Description()
    {
        throw new NotImplementedException();
    }

    public string LivingRoom()
    {
        return $"This {protected_name} is great for your living room, it is {protected_description}!";
    }

    public string Bedroom()
    {
        return $"This {protected_name} is great for your bedroom, it is {protected_description}!";
    }
}
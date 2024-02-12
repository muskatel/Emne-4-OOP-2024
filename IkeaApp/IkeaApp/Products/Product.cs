namespace IkeaApp.Products;

public abstract class Product
{
    protected string protected_name;
    protected float  protected_price;
    protected string protected_shelf;
    protected string protected_description;
    
    protected Product(string name, float price, string shelf, string description)
    {
        this.protected_name = name;
        this.protected_price = price;
        this.protected_shelf = "222." + shelf;
        this.protected_description = description;
    }

    public abstract float Price();

    public abstract String GetShelf();
    
    public abstract String Description();

    protected string ReadAssemblyStepsFromDB()
    {
        // connect to DB and read steps;
        return "Do not assemble alone. Follow steps 1, then 2, then 3";
    }

}
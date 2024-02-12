using IkeaApp.Interfaces;
using IkeaApp.Products;

namespace IkeaApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, IKEA!");

        List<Product> products = new List<Product>();
        products.Add(new Carpet());
        products.Add(new Bookshelf());

        foreach (Product product in products)
        {
            
            if (product is IAssemblable assembleProduct)
            { 
                Console.WriteLine(assembleProduct.Assemble());
            } 
            
            
            if (product is IOffice officeProduct)
            { 
                Console.WriteLine(officeProduct.Office());
            } 
        }
        
    }
}
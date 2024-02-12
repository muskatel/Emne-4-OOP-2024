using IkeaApp.Interfaces;
using IkeaApp.Products;

namespace IkeaApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, IKEA!");

        Product mycarpet = new Carpet();

        
        if (mycarpet is IOffice officeCarpet)
        { 
            Console.WriteLine(officeCarpet.Office());
        }
        
    }
}
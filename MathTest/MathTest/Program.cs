using System.Reflection.Metadata;
using MyMath;

namespace MathTest;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        shapes.Add(new Square(6, 7));
        shapes.Add(new Circle(3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area());
        }
        
    }
}
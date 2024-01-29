namespace MyMath;

public class Circle:Shape
{
    private double radius;

    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    
    /// <summary>
    /// Returns the area of the circle
    /// </summary>
    /// <returns>Area</returns>
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
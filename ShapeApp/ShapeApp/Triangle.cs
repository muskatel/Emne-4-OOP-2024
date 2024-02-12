namespace ShapeApp;

/// <summary>
/// Always a right angle
/// </summary>
public class Triangle: Shape
{
    protected float side_a;
    protected float side_b;

    public Triangle(float sideA, float sideB)
    {
        side_a = sideA;
        side_b = sideB;
    }
}
namespace ShapeApp;

public class Rectangle: Shape
{
    protected float width;
    protected float height;

    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }
}
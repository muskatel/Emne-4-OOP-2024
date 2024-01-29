namespace MyMath;

public class Square:Shape
{
    public double width;
    public double height;

    //"ctorf" then press tab
    public Square(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
    
    
}
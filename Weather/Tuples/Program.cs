namespace Tuples;

class BodyStats : Tuple<double, double>
{
    public BodyStats(double height, double weight)
        :base(height, weight)
    {

    }

    public double Height
    {
        get
        {
            return this.Item1;
        } 
        
    }
    public double Weight { get{ return this.Item2; } }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BodyStats stats = new BodyStats(175, 70);


        List<(double, double)> stats2 = new List<(double Height, double Weight)>
        {
            (Height: 175, Weight: 70),
            (Height:180, Weight: 85)
        };


    }
}
namespace Principles;

class Program
{
    static void Main(string[] args)
    {
        Boat myboat = new Boat();
        Messagebox(myboat.Steer());

        Car mycar = new Car();
        mycar.Steer();
    }

    static void Messagebox(String input)
    {
        //show message in a box
        
        Console.WriteLine(input);
    }
}
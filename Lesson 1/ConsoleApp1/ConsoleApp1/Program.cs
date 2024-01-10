namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Add(35, 7));
        Console.WriteLine(Div(37, 7));
    }

    static int Add(int num1, int num2)
    {
        //Console.WriteLine("Adding " + num1 + " and " + num2);
        //Console.WriteLine($"Adding {num1} and {num2}");
        int solution = num1 + num2;
        return solution;
    }

    static double Div(int num1, int num2)
    {
        return num1 / (double)num2;
    }
}
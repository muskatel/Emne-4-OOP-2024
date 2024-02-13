namespace ClassDemo;

class Program
{
    private static ConsoleKeyInfo cki;
    public delegate double Operation(double number, double other);

    public static double Addition(double number, double other)
    {
        return number + other;
    }
    
    public static double Subtraction(double number, double other)
    {
        return number - other;
    }
    
    public static double Multiplication(double number, double other)
    {
        return number * other;
    }
    
    public static double Division(double number, double other)
    {
        if (other == 0)
        {
            throw new DivideByZeroException();
        }
        return number / other;
    }
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Please enter the first number.\n" +
                          "First number: ");
            //read a number
            // For this example I assume the number will be valid
            double num1 = Double.Parse(Console.ReadLine());


            Console.Write("Please enter the second number.\n" +
                          "Second number: ");

            double num2 = Double.Parse(Console.ReadLine());


            //clear screen
            Console.Clear();
            Operation selectedOperation = null;

            //select operation
            while (selectedOperation == null)
            {
                Console.WriteLine("Please select and operation:\n" +
                                  "[A]ddition\n" +
                                  "[S]ubtraction\n" +
                                  "[M]ultiplication\n" +
                                  "[D]ivision\n" +
                                  "E[x]it");


                if (ReadKey(ref selectedOperation))
                    break;
                Console.Clear();
            }

            //display result
            if (selectedOperation != null)
            {
                Console.WriteLine($"Result:\n" +
                                  $"{selectedOperation(num1, num2)}");
            }
            else
            {
                break;
            }
        }

    }
    
    static bool ReadKey(ref Operation operation)
    {
        cki = Console.ReadKey(false);

        if (cki.Key == ConsoleKey.A)
        {
            operation = Addition;
        }

        if (cki.Key == ConsoleKey.S)
        {
            operation = Subtraction;
        }
            
        if (cki.Key == ConsoleKey.M)
        {
            operation = Multiplication;
        }
            
        if (cki.Key == ConsoleKey.D)
        {
            operation = Division;
        }
        
        if (cki.Key == ConsoleKey.X)
        {
            return true;
        }
        
        return false;
    }
}
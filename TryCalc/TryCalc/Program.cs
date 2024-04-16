// get first number

using TryCalc;

double number1 = ReadNumber(1);

// get second number
double number2 = ReadNumber(2);

// get calculation
char operation = ReadOperation();

Console.Clear();

switch (operation)
{
    case '+':
        Console.WriteLine($"{number1} + {number2} = {number1+number2}");
        break;
    case '-':
        Console.WriteLine($"{number1} - {number2} = {number1-number2}");
        break;
    case '*':
    case 'x':
        Console.WriteLine($"{number1} x {number2} = {number1*number2}");
        break;
    case '/':
        while(number2 == 0)
        {
            number2 = ReadNumber(2);
        }
        Console.WriteLine($"{number1} / {number2} = {number1/number2}");
        break;
}


// perform and output calculation

double ReadNumber(int num)
{
    double number;
    while (true)
    {
        try
        {
            Console.Clear();
            Console.WriteLine($"Please enter number {num}:");
            String input = Console.ReadLine();
            number = Double.Parse(input);
            break;
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
        }
    }

    return number;
}

char ReadOperation()
{
    char op;
    while (true)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Please enter an operation.");
            Console.WriteLine("Use: + - * x /");
            op = (char)Console.Read();

            if (op == '+' || op == '-' || op == '/' || op == 'x' || op == '*')
            {
                break;
            }
            throw new BadOperationException();
        }
        catch (Exception e)
        {
            // nothing to do
        }
    }
    return op;
}
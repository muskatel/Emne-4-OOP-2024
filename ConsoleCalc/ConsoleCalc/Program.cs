namespace ConsoleCalc;

class Program
{
    private static ConsoleKeyInfo cki;

    static void Main(string[] args)
    {
        do
        {
            Calculation calc = null;
            double num1 = 0;
            double num2 = 0;

            bool inputNum1 = true;
            bool inputNum2 = true;

            String input;

            int selected = 0;

            while (inputNum1)
            {
                Console.Clear();
                Console.WriteLine($"Number 1: \t\tNumber 2: ");

                // read number 1
                Console.WriteLine("Please enter the first number.");
                Console.Write("Number 1: ");
                input = Console.ReadLine();
                inputNum1 = !double.TryParse(input, out num1);
            }

            while (inputNum2)
            {
                Console.Clear();
                Console.WriteLine($"Number 1: {num1} \t\tNumber 2:");

                // read number 2
                Console.WriteLine("Please enter the second number.");
                Console.Write("Number 2: ");
                input = Console.ReadLine();
                inputNum2 = !double.TryParse(input, out num2);
            }

            // get operation

            do
            {
                Console.Clear();
                Console.WriteLine($"Number 1: {num1} \t\tNumber 2: {num2}");

                if (selected == 0)
                {
                    Console.WriteLine("[ + Addition       ]");
                }
                else
                {
                    Console.WriteLine("  + Addition  ");
                }

                if (selected == 1)
                {
                    Console.WriteLine("[ - Subtraction    ]");
                }
                else
                {
                    Console.WriteLine("  - Subtraction");
                }

                if (selected == 2)
                {
                    Console.WriteLine("[ x Multiplication ]");
                }
                else
                {
                    Console.WriteLine("  x Multiplication");
                }

                if (selected == 3)
                {
                    Console.WriteLine("[ / Division       ]");
                }
                else
                {
                    Console.WriteLine("  / Division");
                }
            } while (ReadKey(ref selected));

            switch (selected)
            {
                case 0:
                    calc = new Addition();
                    break;
                case 1:
                    calc = new Subtraction();
                    break;
                case 2:
                    calc = new Multiplication();
                    break;
                case 3:
                    calc = new Division();
                    break;
            }



            if (!calc.AssignNumber1(num1) || !calc.AssignNumber2(num2))
            {
                Console.WriteLine(calc.ErrorMessage);
            }
            else
            {
                // show result
                Console.WriteLine($"{num1} {calc} {num2} = {calc.PerformCalculation()}");
            }

            //prompt
            Console.WriteLine($"Press [Enter] to restart or any other key to exit ...");

            if (ReadKey(ref selected))
            {

                break;
            }

        } while (true);
    }

    private static bool ReadKey(ref int selected)
    {
        cki = Console.ReadKey(false);

        if (cki.Key == ConsoleKey.UpArrow)
        {
            selected--;
            if (selected < 0)
                selected = 3;
        }

        if (cki.Key == ConsoleKey.DownArrow)
        {
            selected++;
            if (selected > 3)
                selected = 0;
        }

        if (cki.Key == ConsoleKey.Enter)
        {
            return false;
        }

        return true;
    }
    
}
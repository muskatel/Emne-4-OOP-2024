namespace UserInput;

class Program
{
    private static ConsoleKeyInfo cki;

    static void Main(string[] args)
    {
        int x = 5;
        int y = 5;

        do
        {
            CheckXY(ref x,ref y);
            DrawBox(x, y);

        } while (ReadKey(ref x, ref y));
    }

    static bool ReadKey(ref int x, ref int y)
    {
        cki = Console.ReadKey(false);

        if (cki.Key == ConsoleKey.X)
        {
            return false;
        }

        if (cki.Key == ConsoleKey.LeftArrow)
        {
            x--;
        }
            
        if (cki.Key == ConsoleKey.RightArrow)
        {
            x++;
        }
            
        if (cki.Key == ConsoleKey.UpArrow)
        {
            y--;
        }
            
        if (cki.Key == ConsoleKey.DownArrow)
        {
            y++;
        }
        
        return true;
    }
    
    static void CheckXY(ref int x, ref int y)
    {
        if (x < 0)
        {
            x = 0;
        }

        if (x > 9)
        {
            x = 9;
        }
        
        if (y < 0)
        {
            y = 0;
        }

        if (y > 9)
        {
            y = 9;
        }
    }

    static void DrawBox(int x = 0, int y = 0)
    {
        Console.Clear();
        Console.WriteLine("\u250f\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2513");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\u2503");
            for (int j = 0; j < 10; j++)
            {
                if (y == i && x == j)
                {
                    Console.Write(" 🐸");
                }
                else
                {
                    Console.Write(" _ ");
                }
                
            }
            
            Console.Write("\u2503\n");
        }
        
        Console.WriteLine("\u2517\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u2501\u251b");

    }
}
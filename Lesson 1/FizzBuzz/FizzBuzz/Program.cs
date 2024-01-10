// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine(" Fizz Buzz ");
        Console.WriteLine("-----------");

        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
            if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            Console.Write("\n");
        } 
    }
}


/*  1
    2
    3 Fizz
    4
    5 Buzz
    6
    7
    8
    ...
    15 FizzBuzz
    ...
*/
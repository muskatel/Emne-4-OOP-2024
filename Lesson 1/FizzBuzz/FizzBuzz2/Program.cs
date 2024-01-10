using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Fizz Buzz ");
        Console.WriteLine("-----------");

        FizzBuzzer();
        FizzBuzzer();
        // End of program
    }

    static void FizzBuzzer()
    {
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

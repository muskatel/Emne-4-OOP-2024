namespace AgeChecker;

class Program
{
    /*
     * Write a program for checking the age of a user.
     * Legal to buy alcohol?
     * over 18 -> Beer
     * over 20 -> Liquor
     * over 14 -> Energy Drink
     * over 21 -> Alcohol in US
     */
    static void Main(string[] args)
    {

        int age;
        String input = "not a number";


        while (!int.TryParse(input, out age))
        {
            Console.Write("Please enter your age: ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Your age is {age}.");

        if (age >= 14)
        {
            Console.WriteLine("Energy Drink \u2705 ");
        }

        if (age >= 18)
        {
            Console.WriteLine("Beer \u2705 ");
        }

        if (age >= 20)
        {
            Console.WriteLine("Liquor \u2705 ");
        }

        if (age >= 21)
        {
            Console.WriteLine("In the US🇺🇸 \u2705 ");
        }
    }
}
using System.ComponentModel.Design;

namespace LuhnChecker;

class Program
{
    static int numerb = 1000;
    static void Main(string[] args)
    {
        string name = "Craig Marais";
        Console.WriteLine($"Luhn Checker by {name}");
        
        foreach (string num in args)
        { 
            Console.Write(num);
            if (Checker(num))
            {
                Console.Write(" - valid");
            }
            else
            {
                Console.Write(" - invalid");
            }
            Console.Write("\n");
        }

        
        /*
         * Code me please...
         */
    }

    /// <summary>
    /// A method for checking a number using the Luhn Algorithm.
    /// </summary>
    /// <param name="num">The number to check.</param>
    /// <returns>(bool): True if the number is valid according to the Luhn
    /// algorithm, otherwise False.</returns>
    static bool Checker(string num)
    {
        // Copy all but the last digit into a new string
        string numToCheck = num.Substring(0, num.Length - 1);
        // Substring method start from 0 and has length of one less than
        // the previous string
        
        // Copy off the last digit for later calculation
        Char checkDigit = num[num.Length - 1]; // Array thus zero index start 
        int correctDigit = int.Parse(checkDigit.ToString());
        
        // from here
        if( Luhn(numToCheck) == correctDigit)
        {
            return true;
        }
        else
        {
            return false;
        }
        // to here
        
        // is equivalent to:
        // return Luhn(numToCheck) == correctDigit;

        // Take a given number, remove the last digit and then call Luhn()
        // If the number returned by Luhn() matches the removed item, then
        // the number is valid.
    }

    /// <summary>
    /// An implementation of the Luhn Algorithm.
    /// https://en.wikipedia.org/wiki/Luhn_algorithm
    /// </summary>
    /// <param name="num">The number to check.</param>
    /// <returns>(int): The check digit for the provided number.</returns>
    static int Luhn(string num)
    {
        int sum = 0;
        
        // start from the back of the string
        for (int i = num.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(num[i].ToString());

            // double on even digits
            if (i % 2 == 0)
            {
                digit *= 2;
            }

            if (digit >= 10)
            {
                // 5 -> 10 -> 1
                // 6 -> 12 -> 3
                // 7 -> 14 -> 5
                // 8 -> 16 -> 7
                // 9 -> 18 -> 9
                                    
               // 12 -> 1 + 2 = 3
               digit = (digit % 10) + 1;
               // equivalent to: digit -= 9;
            }

            sum += digit; //47
        }

        // (sum % 10) = 7
        // 10 - (sum % 10) = 3
        // (10 - (sum % 10)) % 10 = 3
        return (10 - (sum % 10)) % 10;
    }
}
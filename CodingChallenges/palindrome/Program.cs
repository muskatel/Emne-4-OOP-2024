namespace palindrome;

class Program
{
    static void Main(string[] args)
    {
        List<String> palindromes = new List<string>()
        {
            "TENET",
            "oxooxo",
            "racecar",
            "Never odd or even",
            "Craig is not a potato"
        };

        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
            if (CheckIfPalindrome(palindrome))
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is NOT a palindrome");
            }
        }


    }

    /// <summary>
    /// Checks if a given string is a palindrome or not
    /// </summary>
    /// <param name="candidate"></param>
    /// <returns>True or false</returns>
    public static bool CheckIfPalindrome(String candidate)
    {
        string input = "";
        
        // can be shortened with LINQ
        foreach (char c in candidate.ToLower())
        {
            if (!Char.IsWhiteSpace(c))
                input += c;
        }

        for (int i = 0; i < Math.Ceiling(input.Length/2.0); i++)
        {
            Console.WriteLine(input[i] + " vs. "+ input[input.Length-(i+1)]);
            if (input[i] != input[input.Length - (i + 1)])
            {
                return false;
            }
        }
        return true;
    }
}
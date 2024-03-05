namespace CodingChallenges;

class Program
{
    static void Main(string[] args)
    {
        String words = "Hello, class!";

        char[] wordsArray = words.ToCharArray();
        string output = "";
        for (int i = wordsArray.Length-1; i >= 0; i--)
        {
            //Console.Write(wordsArray[i]);
            output += wordsArray[i];
        }
        
        
        Console.WriteLine(output);
    }
}
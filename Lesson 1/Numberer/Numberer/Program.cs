namespace Numberer;

class Program
{
    static void Main(string[] args)
    {
        foreach (string s in args)
        {
            Console.Write(s + "\t" );
            if (s.Length > 12)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("valid");
            }
            
            Console.ReadLine();
        }
    }
}
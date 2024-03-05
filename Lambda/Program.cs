using System.Net.Sockets;

namespace Lambda;

class Program
{
    delegate int Op(int x, int y);
    
    delegate void Thing();
    
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Minus(int x, int y)
    {
        return x - y;
    }
    
    static void Main(string[] args)
    {
        char input = 'm';
        int num = 0;

        Op opToPerform = null;
        
        switch (input)
        {
            case 'p':
                // plus
                opToPerform = Add;
                //num = Add(35, 7);
                break;
            case 'm' :
                // minus
                opToPerform = Minus;
                //num = Minus(35, 7);
                break;
        }

        int i = 0;

        num = opToPerform(35, 7);
        
        Console.WriteLine(num);

        List<Op> steps = new List<Op>();
        
        steps.Add(Add);
        steps.Add(Minus);
        steps.Add(Add);

        foreach (Op p in steps)
        {
            p.Invoke(3, 3);
        }

        Thing doME = Console.WriteLine;

        
        
    }
}
using System.Text;

namespace SodokuValidator;

public class Sodoku
{
    public bool IsValidSudoku(char[][] board)
    {
        // rows 
        for (int i = 0; i < 9; i++)
        {
            char[] row = board[i];
            
            //check row
            if (!CheckSet(row))
            {
                Console.Write("Row: ");
                Console.WriteLine(row);
                return false;
            }
        }
        
        
        // columns
        for (int i = 0; i < 9; i++)
        {
            char[] col = new char[9];
            for (int j = 0; j < 9; j++)
            {
                col[j] = board[j][i];
            }
            
            //check column
            if (!CheckSet(col))
            {
                Console.Write("Col: ");
                Console.WriteLine(col);
                return false;
            }
        }
        
        
        // inner blocks

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // [A][B][C]
                // [D][E][F]
                // [G][H][I]

                char[] block = new char[9];

                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        block[(x * 3) + y] = board[(i * 3) + x][(j * 3) + y];
                    }
                }

                // check block
                if (!CheckSet(block))
                {
                    Console.Write("Blk: ");
                    Console.WriteLine(block);
                    return false;
                }
            }
        }
        return true;
    }

    public bool CheckSet(char[] set)
    {
        HashSet<char> checker = new HashSet<char>();
        foreach (char c in set)
        {
            if (c != '.')
            {
                if (checker.Contains(c))
                {
                    return false;
                }
                checker.Add(c);
            }
        }
        return true;
    }
}

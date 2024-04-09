namespace RPG_Game;

public class World
{
    public int width = 80;
    public int height = 25;

    public List<Enemy> enemies;
    

    public ConsoleKeyInfo cki = new ConsoleKeyInfo();

    public Action Exit;

    private Character player;
    
    private char c = '\u263a';

    public World()
    {
        player = new Character();
        enemies = new List<Enemy>();
        
        enemies.Add(new Enemy(new Position(50,20), player));
        
        enemies.Add(new Enemy(new Position(60,20), player));
        
        enemies.Add(new Enemy(new Position(20,20), player));

    }

    bool ReadKey()
    {
        cki = Console.ReadKey(false);

        if (cki.Key == ConsoleKey.X || cki.Key == ConsoleKey.Spacebar)
        {
            Exit();
            return false;
        }

        if (cki.Key == ConsoleKey.LeftArrow)
        {
            player.position.X--;
        }
            
        if (cki.Key == ConsoleKey.RightArrow)
        {
           
            player.position.X++;
        }
            
        if (cki.Key == ConsoleKey.UpArrow)
        {
            
            player.position.Y--;
        }
            
        if (cki.Key == ConsoleKey.DownArrow)
        {
            
            player.position.Y++;
        }
        
        return true;
    }

    public void Update()
    {
        if (ReadKey())
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Update();
            }   
        }
    }

    public void Draw()
    {
        Console.Clear();
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
                {
                    Console.Write("X");
                }
                else if (player.position.X == i && player.position.Y == j)
                {
                    Console.Write(player);
                }
                else
                {
                    List<Enemy> current = enemies
                        .FindAll(enemy => enemy.position.X == i && enemy.position.Y == j);
                        
                    if(current.Count > 0)
                    {
                        Console.Write(current.First());
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.Write("\n");
        }
    }
}

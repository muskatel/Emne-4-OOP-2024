namespace RPG_Game;

class Program
{
    static private bool running = true;
    static void Main(string[] args)
    {
        World world = new World();
        world.Exit = StopRunning;
        
        do
        {
            world.Draw();
            world.Update();
        } 
        while (running);
    }

    static public void StopRunning()
    {
        running = false;
    }
    
}
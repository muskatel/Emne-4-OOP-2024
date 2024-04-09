namespace RPG_Game;

public class Enemy
{
    
    public int health;
    public Position position;
    private Character player;

    public Enemy(Position position,Character player , int health = 1)
    {
        this.health = health;
        this.player = player;
        this.position = position;
    }

    public override string ToString()
    {
        return "x";
    }

    public void Update()
    {
        //move towards player
        if (position.X < player.position.X)
        {
            position.X++;
        }
        
        if (position.X > player.position.X)
        {
            position.X--;
        }
        if (position.Y < player.position.Y)
        {
            position.Y++;
        }
        
        if (position.Y > player.position.Y)
        {
            position.Y--;
        }
    }
}
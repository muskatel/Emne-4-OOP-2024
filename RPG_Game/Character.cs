namespace RPG_Game;

public enum Direction
{
    North,
    East,
    Souht,
    West
}


public class Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Character
{
    public int health;
    public Position position = new Position(10,10);

    public override string ToString()
    {
        return '\u263a'.ToString();
    }
}
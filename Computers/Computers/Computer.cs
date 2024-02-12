namespace Computers;

public class Computer
{
    public IKeyboard Keyboard { get; }
    public StandardScreen screen = new StandardScreen();

    public Computer(IKeyboard keyboard)
    {
        this.Keyboard = keyboard;
    }



}
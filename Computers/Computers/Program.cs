namespace Computers;

class Program
{
    static void Main(string[] args)
    {
        Computer myNewMacBook = new Computer(new StandardKeyboard());
        
        myNewMacBook.Keyboard.PressKey();
        myNewMacBook.Keyboard = new FancyKeyboard();
        
        myNewMacBook.screen.Display("cat.jpg", 100000,100000);
        
        Computer differentComputer = new Computer(new FancyKeyboard());
        differentComputer.Keyboard.PressKey();
    }
}
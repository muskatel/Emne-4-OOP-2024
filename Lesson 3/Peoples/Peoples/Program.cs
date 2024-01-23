namespace Peoples;

class Program
{
    static void Main(string[] args)
    {
        Person me = new Person("Craig Marais");
        
        me.update(new DateTime(1985,06,12));
        
        Console.WriteLine(me.getName());
        Console.WriteLine(me.getAge());
    }
}
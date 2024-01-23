namespace Peoples;

class Program
{
    static void Main(string[] args)
    {
        Person me = new Person("Craig Marais", new PersonNumber(2));

        me.update(new DateTime(1985, 06, 12));
        me.setAddress(new House("Ammerud, Oslo"));
        
        if (me.getAddress() != null)
        {
            Console.WriteLine(me.getAddress());
        }

        Console.WriteLine(me.getName());
        Console.WriteLine(me.getAge());


        House differentHouse = new House("Sandefjord");
        Console.WriteLine(differentHouse);
    }
}
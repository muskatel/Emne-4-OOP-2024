namespace Peoples;

class Program
{
    static void Main(string[] args)
    {
        Teacher me = new Teacher("Craig Marais", new PersonNumber(2));

        me.Salary = 10;
        me.Department = "Full-stack";
        
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
        
        PrintedMedia thing = new PrintedMedia("Experimental Thing", 1);
        Book lotr = new Book("Lord of the Rings", 1, "4372395", true);

        Console.WriteLine(thing.CountWords());
        Console.WriteLine(lotr.CountWords());
        
        
        
        
        List<Person> people = new List<Person>();
        people.Add(new Student("Bobbington",new PersonNumber(11)));
        people.Add(new Student("Suzy",new PersonNumber(12)));
        people.Add(new Student("Jeff",new PersonNumber(42345)));
        people.Add(new Teacher("Graig", new PersonNumber(2)));

        foreach (Person pers in people)
        {
            Console.WriteLine(pers.getName());
            if (pers is Teacher)
            {
                Console.WriteLine(((Teacher)pers).Department);
            }
        }
    }
}
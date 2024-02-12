namespace AbstractAnimals;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> myHouse = new List<Animal>();
        myHouse.Add(new Cat());
        myHouse.Add(new Mouse());
        myHouse.Add(new Parrot());

        foreach (Animal animal in myHouse)
        {
            animal.getInfo();
            animal.makeNoise();

            /*
            NAD BAD BAD 
             
            Cat cat = animal as Cat;
            if(cat!= null)
            {
                cat.makeNoise();
            }
            
            Mouse mouse = animal as Mouse;
            if(mouse!= null)
            {
                mouse.makeNoise();
            }
            */
            
        }
    }
}
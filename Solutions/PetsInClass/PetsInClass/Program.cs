namespace PetsInClass;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        
        List<Pet> myPets = []; // new List<Pet>();
        
        //Cat myCat1 = new Cat("Fuffykins");
        //Cat myCat2 = new Cat("Bob");
        
        myPets.Add(new Cat("Fuffykins"));
        myPets.Add(new Cat("Bob"));
        
        myPets.Add(new Dog("Steeve"));
        myPets.Add(new Dog("Max"));
        
        myPets.Add(new Fish("Bubbles"));
        myPets.Add(new Fish("Illlidan"));

        /*
        for (int i = 0; i < myPets.Count; i++)
        {
            Pet pet = myPets[i];
        }
        */

        //Pet demo = new Fish("Malfurion");
        
        foreach (Pet pet in myPets)
        {
            Console.WriteLine($"{pet} named {pet.GetName()} " +
                              $"makes a {pet.GetNoise()} noise " +
                              $"and can {pet.GetTrick()}.");
        }
    }
}
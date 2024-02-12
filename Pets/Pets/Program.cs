namespace Pets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Pets!");
        
        // Create a collection of Pets
        List<Pet> myPets = new List<Pet>();

        // Create 2 of each pet, adding them to the collection
        myPets.Add(new Cat("Fluffykins"));
        myPets.Add(new Cat("Floofbutt"));
        
        myPets.Add(new Dog("Max"));
        myPets.Add(new Dog("Spot"));
        
        myPets.Add(new Fish("Wilfred"));
        myPets.Add(new Fish("Sofie"));
        
        //Iterate through each animal and print info
        foreach (Pet pet in myPets)
        {
            String PetAsString = pet.GetType().ToString().Substring(5);
            
            Console.WriteLine(
                $"{pet.GetName()} is a {PetAsString}, " +
                $"it can \"{pet.GetTrick()}\" and " +
                $"makes a \"{pet.GetNoise()}\" noise.");
        }
    }
}
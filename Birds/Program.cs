using Birds.Interfaces;
using Birds.Species;

namespace Birds;

class Program
{
    static void Main(string[] args)
    {
        List<Bird> birds = new List<Bird>();
        
        birds.Add(new Crow());
        birds.Add(new Duck());
        birds.Add(new Penguin());
        birds.Add(new Thrush());


        foreach (Bird bird in birds)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(bird);
            Console.WriteLine("-------------------------------------");
            if (bird is IFly flybird)
            {
                flybird.Fly();
            }
            
            if (bird is IFloat floatbird)
            {
               floatbird.Float();
            }
            
            if (bird is INoise noisebird)
            {
                noisebird.Noise();
            }
            
            if (bird is ISwim swimbird)
            {
               swimbird.Swim();
            }
            Console.WriteLine("-------------------------------------\n");
        }
    }
}
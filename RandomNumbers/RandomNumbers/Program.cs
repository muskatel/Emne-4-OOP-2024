namespace RandomNumbers;

class Program
{
    static void Main(string[] args)
    {
        String[] names =
        {
            "Aldric Ironheart",
            "Sylvia Moonshadow",
            "Thrain Fireforge",
            "Elowen Stormrider",
            "Gideon Ravenwing",
            "Isolde Lionheart",
            "Bran Shadowblade",
            "Elysia Starfall",
            "Faelan Dragonbane",
            "Seraphina Thunderfoot",
            "Cedric Frostbeard",
            "Lavinia Emberflame",
            "Percival Stormcaller",
            "Rowan Silverleaf",
            "Morgana Frostshadow",
            "Gareth Swiftwind",
            "Rosalind Darkwater",
            "Finnian Stonehelm",
            "Celestia Skydancer",
            "Alaric Blackthorn"
        };
        
        
        Console.WriteLine("Hello, World!");

        Random random = new Random();
        /*
        for (int i = 0; i < 10; i++)
        {
           Console.WriteLine(random.Next(0,100));
        }
        */
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(names[random.Next(0, names.Length)]);
        }
    }
}
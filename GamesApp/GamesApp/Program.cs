using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GamesApp;

class Program
{
    static void Main(string[] args)
    {
        
        // Open a file using Stream reader
        StreamReader sr = new StreamReader("games.json");
        
        // Handle the file contents using Json Text reader
        JsonTextReader tr = new JsonTextReader(sr);

        // Convert tot JObject through JToken
        JObject jo = (JObject)JToken.ReadFrom(tr);

        String data = "";

        while (!sr.EndOfStream)
        {
            data += sr.ReadLine();
        }

        List<Game> games = JsonConvert.DeserializeObject<List<Game>>(data);
        
        /*
        while (!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());
        }
        */
        Console.ReadKey();

        /*
        if (File.Exists("games.json"))
        {
            Console.WriteLine("File exists!");
        }
        else
        {
            Console.WriteLine("No file!");
        }
        */
    }
}
using System.Text.Json.Serialization;
using MySqlConnectionExample;
using MySqlConnector;

String server = "localhost";
String username = "root";
String password = "gokstad";
String port = "3306";
String database = "world";

string connectionString = $"server={server};" +
                         $"user={username};" +
                         $"database={database};" +
                         $"port={port};" +
                         $"password={password}";

MySqlConnection conn = new MySqlConnection(connectionString);
Console.WriteLine("Attempting to connect");
conn.Open();
Console.WriteLine($"Connect to {server}");

String selectStatement = "SELECT * from country;";

MySqlCommand selectCommand= new MySqlCommand(selectStatement, conn);

Console.WriteLine("Reading data");
MySqlDataReader reader = selectCommand.ExecuteReader();

List<Country> World = new List<Country>();

while (reader.Read())
{
    World.Add(new Country()
    {
      Code  = (String)reader["Code"],
      Name  = (String)reader["Name"],
      Continent  = (String)reader["Continent"]
    });
}

Console.WriteLine("Read complete");
conn.Close();

foreach (Country country in World)
{
    Console.WriteLine($"{country.Name} - {country.Code}");
}
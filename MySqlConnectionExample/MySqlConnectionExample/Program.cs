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
    Country c = new Country();
    c.Code = (String)reader["Code"];
    c.Name = (String)reader["Name"];
    c.Continent = (String)reader["Continent"];
    c.Region = (String)reader["Region"];
    
    if (reader["SurfaceArea"] == DBNull.Value)
    {
        c.SurfaceArea = 0;
    }
    else
    {
        c.SurfaceArea = Double.Parse(reader["SurfaceArea"].ToString());
    }
    
    if (reader["IndepYear"] == DBNull.Value)
    {
        c.IndepYear = 0;
    }
    else
    {
        c.IndepYear = int.Parse(reader["IndepYear"].ToString());
    }
    
    if (reader["Population"] == DBNull.Value)
    {
        c.Population = 0;
    }
    else
    {
        c.Population = (int)reader["Population"];
    }
    
    if (reader["LifeExpectancy"] == DBNull.Value)
    {
        c.LifeExpectancy = 0;
    }
    else
    {
        c.LifeExpectancy = Double.Parse(reader["LifeExpectancy"].ToString());
    }
    
    if (reader["GNP"] == DBNull.Value)
    {
        c.GNP = 0;
    }
    else
    {
        c.GNP = Double.Parse(reader["GNP"].ToString());
    }
    
    if (reader["GNPOld"] == DBNull.Value)
    {
        c.GNPOld = 0;
    }
    else
    {
        c.GNPOld = Double.Parse(reader["GNPOld"].ToString());
    }
    
    c.LocalName = (String)reader["LocalName"];
    c.GovernmentForm = (String)reader["GovernmentForm"];
    c.HeadOfState = reader["HeadOfState"].ToString();
    
    if (reader["Capital"] == DBNull.Value)
    {
        c.Capital = 0;
    }
    else
    {
        c.Capital = (int)reader["Capital"];
    }
    c.Code2 = (String)reader["Code2"];

    World.Add(c);
}

Console.WriteLine("Read complete");
conn.Close();

foreach (Country country in World)
{
    Console.WriteLine($"{country.Name} - {country.Code}");
}
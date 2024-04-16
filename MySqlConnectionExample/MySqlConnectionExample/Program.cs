using System.Text.Json.Serialization;
using MySqlConnectionExample;
using MySqlConnectionExample.DbClasses;
using MySqlConnector;

List<Country> World = new List<Country>();
List<City> Cities = new List<City>();

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

#region Read City data
    
    String selectCityStatement = "SELECT * from city;";
    MySqlCommand selectCityCommand= new MySqlCommand(selectCityStatement, conn);
    Console.WriteLine("Reading city data");
    MySqlDataReader cityReader = selectCityCommand.ExecuteReader();

    while (cityReader.Read())
    {
        City city = new City();
        city.ID = int.Parse(cityReader["ID"].ToString());
        city.Name = (String)cityReader["Name"];
        city.CountryCode = (String)cityReader["CountryCode"];
        city.District = (String)cityReader["District"];
        if (cityReader["Population"] == DBNull.Value)
        {
            city.Population = 0;
        }
        else
        {
            city.Population = int.Parse(cityReader["Population"].ToString());
        }
        Cities.Add(city);
    }
    cityReader.Close();
    Console.WriteLine("Read of city data complete");

#endregion

#region Read Country data
    String selectStatement = "SELECT * from country;";
    MySqlCommand selectCommand= new MySqlCommand(selectStatement, conn);
    Console.WriteLine("Reading country data");
    MySqlDataReader reader = selectCommand.ExecuteReader();

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
            c.CapitalCity = new City() { Name = "", District = "", Population = 0, CountryCode = ""};
        }
        else
        {
            c.Capital = (int)reader["Capital"];
            c.CapitalCity = Cities.Find(city => city.ID == c.Capital);
        }
        c.Code2 = (String)reader["Code2"];

        World.Add(c);
    }
    reader.Close();
    Console.WriteLine("Read of country data complete");

#endregion

conn.Close();

// ready to do stuff!

/* LINQ Structure
   RESULT = FROM ELEMENT IN COLLECTION
	        WHERE CONDITION
		    ARRANGE
	        SELECT ELEMENT
 */

//LINQ

// Life expectancy over 80
IEnumerable<Country> results =
    from Country in World
    where Country.LifeExpectancy >= 80
    orderby Country.Region
    select Country;
Console.WriteLine("----------------------");
foreach (Country country in results)
{
    Console.WriteLine(country.Name + " - " + country.Region);
    Console.WriteLine("Life Expectancy:" + country.LifeExpectancy);
}
Console.WriteLine("----------------------");
// IEnumerable<Country> results_other =
//     World.FindAll(county => county.LifeExpectancy >= 80)
//         .OrderBy(county => county.Region);
//
// foreach (Country country in results_other)
// {
//     Console.WriteLine(country.Name + " - " + country.Region);
//     Console.WriteLine("Life Expectancy:" + country.LifeExpectancy );
// }
// Console.WriteLine("----------------------");

//find cities in Sweden

Console.WriteLine("Please enter country code:");
String code = "ZAF";//Console.ReadLine().Trim().ToUpper();

Country userCountry =
    World.Single(county => county.Code == code);

IEnumerable<City> res1 =
    // declarative query syntax
    from City in Cities
    where City.CountryCode == code.Trim().ToUpper()
    select City;


Console.WriteLine($"Cities in {userCountry.LocalName}");
foreach (City city in res1)
{
    Console.WriteLine(city.Name);
}

/* LINQ Structure
   RESULT = FROM ELEMENT IN COLLECTION
	        WHERE CONDITION
		    ARRANGE
	        SELECT ELEMENT
 */


//give city name find the pop of the country
Console.WriteLine("Please enter city name:");
String input = Console.ReadLine().Trim().ToUpper();


Country cr = World
    .Single(
        country => country.Code == Cities.First(
            city => city.Name.ToUpper() == input
            )
            .CountryCode);


Console.WriteLine(cr.LocalName +" "+ cr.Population);











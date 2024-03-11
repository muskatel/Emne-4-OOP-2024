using MySql.Data.MySqlClient;

namespace DBConnection;

class Program
{
    static void Main(string[] args)
    {
        MySqlConnection connection;
        string server = "localhost"; // or IP
        string database = "world";
        string user = "root";
        string password = "gokstad";
        string port = "3306";
        string sslM = "none";

        String SelectCityString = $"SELECT * FROM city;";


        MySqlCommand readCityCommand;
        MySqlDataReader reader = null;
        
        

        string connectionString =
            $"server={server};port={port};user id={user}; password={password}; database={database}; SslMode={sslM}";

        connection = new MySqlConnection(connectionString);

        
        try
        {
            connection.Open();

            Console.WriteLine("Successfully connected");

            readCityCommand = new MySqlCommand(SelectCityString, connection);
            reader = readCityCommand.ExecuteReader();
            
            while(reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32("ID")}: {reader.GetString("Name")}");
            }
            
            Console.WriteLine("Done. Disconnecting");
            connection.Close();
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message + connectionString);
        }

    }
}
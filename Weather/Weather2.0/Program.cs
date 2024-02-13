namespace Weather2._0;

class Program
{
    delegate bool Warning(double temperature, double humidity,ref string message);

    static bool FreezingWarning(double temperature, double humidity, ref string message)
    {
        if (temperature <= 0)
        {
            message = "--- Freezing warning!!! ---";
            return true;
        }

        return false;
    }
    
    static bool RainWarning(double temperature, double humidity,ref string message)
    {
        if (humidity >=50)
        {
            message = "--- Rain warning!!! ---";
            return true;
        }

        return false;
    }
    
    static void Main(string[] args)
    {
        List<(double Temperature, double Humidity)> weatherConditions =
        [
            (20.0, 40.0),
            (10.0, 50.0),
            (20.0, 50.0),
            (-4, 15),
            (0, 10),
            (15, 75)
            
        ];
        weatherConditions.Add((20.0, 50.0));

        List<Warning> warnings = new List<Warning>()
        {
            FreezingWarning,
            RainWarning
        };
        

        foreach ((double Temperature, double Humidity) condition in weatherConditions)
        {
            Console.WriteLine($"\nConditions \n" +
                              $"Temp:{condition.Temperature}\n" +
                              $"Humidity:{condition.Humidity}");
            foreach (Warning warning in warnings)
            {
                string message = "";
                if (warning(condition.Temperature, condition.Humidity, ref message))
                {
                    Console.WriteLine(message);
                }
            }

        }

    }
}
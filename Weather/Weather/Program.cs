using System.Reflection;

namespace Weather;

public delegate bool WeatherWarning(double temperature);


class Program
{
    public static bool FreezingWarning(double temperature)
    {
        if (temperature <= 0)
        {
            return true;
        }

        return false;
    }
    
    public static bool SuperFreezingWarning(double temperature)
    {
        if (temperature <= -20)
        {
            return true;
        }

        return false;
    }

    public static List<double> CheckTemperatures(List<double> temperatures, WeatherWarning warning)
    {
        List<double> warningActive = new List<double>();        
        foreach (double temp in temperatures)
        {
            if (warning(temp))
            {
                warningActive.Add(temp);
            }
        }
        return warningActive;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        WeatherWarning freezing = FreezingWarning;
        WeatherWarning superFreezing = SuperFreezingWarning;

        List<WeatherWarning> warnings = new List<WeatherWarning>();
        
        warnings.Add(FreezingWarning);
        warnings.Add(SuperFreezingWarning);

        List<double> temperatures = new List<double>();  
        
        temperatures.Add(23);
        temperatures.Add(-23);
        temperatures.Add(-3);
        temperatures.Add(-2);
        temperatures.Add(6);
        temperatures.Add(11);
        temperatures.Add(18);
        
        foreach (double temp in temperatures)
        {
            Console.WriteLine($"It is {temp} degrees");
        }

        List<double> freezingTemps = CheckTemperatures(temperatures, FreezingWarning);

        foreach (double temp in freezingTemps)
        {
            Console.WriteLine($"It is freezing: {temp}");
        }

        /*
        double temperature = -30;

        if (freezing(-4))
        {
            Console.WriteLine("it is freezing\n");
        }

        foreach (WeatherWarning warning in warnings)
        {
            if (warning(temperature))
            {
                Console.WriteLine(warning.GetMethodInfo());
                Console.WriteLine("warning was true\n");
            }
        }

        */

    }
}
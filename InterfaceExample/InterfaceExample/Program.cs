using InterfaceExample.Vehicles;

namespace InterfaceExample;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car(4, 5));
        vehicles.Add(new Pram(4, 1));
        vehicles.Add(new Train(24, 200));
        vehicles.Add(new Trolley(4, 0));

        List<ISteerable> steerables = GetSteerableVehicles(vehicles);

        foreach (ISteerable steerable in steerables)
        {
            steerable.Steer();
            steerable.Stop();
        }
    }

    /// <summary>
    /// Given a list of Vehicles this will return a subset of ISteerable vehicles.
    /// </summary>
    /// <param name="vehicles">A list of Vehicles</param>
    /// <returns>A list of ISteerables</returns>
    public static List<ISteerable> GetSteerableVehicles(List<Vehicle> vehicles)
    {
        List<ISteerable> steerables = new List<ISteerable>();
        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle is ISteerable steerable)
            {
                steerables.Add(steerable);
            }
        }
        return steerables;
    }
}
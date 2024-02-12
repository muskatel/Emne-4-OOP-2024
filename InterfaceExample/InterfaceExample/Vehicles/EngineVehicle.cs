namespace InterfaceExample.Vehicles;

public class EngineVehicle: Vehicle
{
    public EngineVehicle(int wheels, int seats)
    :base(wheels, seats)
    {
        
    }

    public void StartEngine()
    {
        Console.WriteLine("The engine was started");
    }
}
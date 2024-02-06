namespace InterfaceExample.Vehicles;

public class Trolley: PushVehicle, ISteerable
{
    public Trolley(int wheels, int seats) : base(wheels, seats)
    {
    }

    public void Steer()
    {
        Console.WriteLine("Steer the trolley using the handle.");
    }

    public void Stop()
    {
        Console.WriteLine("Stop the trolley using the handle.");
    }
}
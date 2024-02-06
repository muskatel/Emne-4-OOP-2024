namespace InterfaceExample.Vehicles;

public class Pram : PushVehicle, ISteerable
{
    public Pram(int wheels, int seats) : base(wheels, seats)
    {
    }

    public void Steer()
    {
        Console.WriteLine("Steer the pram using the handle.");
    }

    public void Stop()
    {
        Console.WriteLine("Stop the pram using the handle.");
    }
}
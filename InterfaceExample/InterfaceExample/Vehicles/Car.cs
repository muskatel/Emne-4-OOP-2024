namespace InterfaceExample.Vehicles;

public class Car: EngineVehicle, ISteerable
{
    public Car(int wheels, int seats) 
    : base(wheels, seats)
    {
        
    }

    public void Steer()
    {
        Console.WriteLine("Steer the car with the steering wheel.");
    }

    public void Stop()
    {
        Console.WriteLine("Stop the car with the brakes.");
    }
}
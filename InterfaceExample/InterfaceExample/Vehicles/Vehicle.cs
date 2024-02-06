namespace InterfaceExample.Vehicles;

public abstract class Vehicle
{
    protected int Wheels;
    protected int Seats;

    protected Vehicle(int wheels, int seats)
    {
        Wheels = wheels;
        Seats = seats;
    }
}
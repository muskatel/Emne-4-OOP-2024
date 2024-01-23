namespace Peoples;

public class House
{
    private String address;

    public House(string address)
    {
        this.address = address;
    }

    public override String ToString()
    {
        return "House: " + address;
    }
}
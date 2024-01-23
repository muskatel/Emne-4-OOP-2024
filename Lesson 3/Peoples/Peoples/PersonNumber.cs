namespace Peoples;

public class PersonNumber
{
    private int personNumber;

    //ctorf
    public PersonNumber(int personNumber)
    {
        // validate number 
        this.personNumber = personNumber;
    }

    public int Number
    {
        get => personNumber;
        set => personNumber = value;
    }
}
namespace Peoples;

public class Person
{
    // Person.cs
    // ------------------
    // - fullname: String
    // - birthday: Date*
    // ------------------
    // + Person ()
    // + Person (String)
    // + update (Date)
    // + getName (): String
    // + getAge (): int
    // ------------------
    
    private String fullname;
    private DateTime birthday;

    private PersonNumber personNumber;

    private House house;

    protected string telephone;

    /// <summary>
    /// Basic Person constuctor, will set name as Undefined
    /// </summary>
    public Person(PersonNumber personNumber)
    {
        this.personNumber = this.personNumber;
        fullname = "Undefined";
    }

    /// <summary>
    /// Person Constructor that will set a persons fullname 
    /// </summary>
    /// <param name="fullname">The full name</param>
    public Person(String fullname, PersonNumber personNumber)
    {
        this.personNumber = this.personNumber;
        this.fullname = fullname;
    }
    
    /// <summary>
    /// Complex constructor that will create a fullname from first and last
    /// </summary>
    /// <param name="firstname">The firstname</param>
    /// <param name="lastname">The lastname</param>
    public Person(String firstname, String lastname, PersonNumber personNumber)
    {
        this.personNumber = this.personNumber;
        this.fullname = firstname + " " + lastname;
    }

    public String getName()
    {
        return fullname;
    }

    public void update(DateTime dob)
    {
        birthday = dob;
    }

    public int getAge()
    {
        int age = DateTime.Now.Year - birthday.Year;

        return age;
    }

    public void setAddress(House house)
    {
        // check that the house is valid
        this.house = house;
    }
    
    public House getAddress()
    {
        return house;
    }
}
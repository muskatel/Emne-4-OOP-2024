namespace Peoples;

public class Teacher:Person
{
    private string department = "Undefined";
    private int salary;
    private string subject = "i dunno";
    public Teacher(PersonNumber personNumber) : base(personNumber)
    {
        
    }

    public Teacher(string fullname, PersonNumber personNumber) : base(fullname, personNumber)
    {
    }

    public Teacher(string firstname, string lastname, PersonNumber personNumber) : base(firstname, lastname, personNumber)
    {
    }

    public int Salary
    {
        get => salary;
        set => salary = value;
    }

    public string Department
    {
        get => department;
        set => department = value;
    }

}
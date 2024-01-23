namespace Peoples;

public class Student: Person
{
    private string subject;
    
    public Student(PersonNumber personNumber) : base(personNumber)
    {
    }

    public Student(string fullname, PersonNumber personNumber) : base(fullname, personNumber)
    {
    }

    public Student(string firstname, string lastname, PersonNumber personNumber) : base(firstname, lastname, personNumber)
    {
    }

    public string Subject
    {
        get => subject;
        set => subject = value;
    }
}
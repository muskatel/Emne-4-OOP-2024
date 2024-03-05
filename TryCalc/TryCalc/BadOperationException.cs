namespace TryCalc;

public class BadOperationException: Exception
{
    public BadOperationException()
    :base("Bad operation selected")
    {
        
    }
}
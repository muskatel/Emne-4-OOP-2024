namespace ConsoleCalc;

public abstract class Calculation
{
    protected double num1;
    protected double num2;

    public String ErrorMessage = "No error.";

    public virtual bool AssignNumber1(double num1)
    {
        this.num1 = num1;
        return true;
    }
    
    public virtual bool AssignNumber2(double num2)
    {
        this.num2 = num2;
        return true;
    }
    

    public virtual double PerformCalculation()
    {
        throw new NotImplementedException();
    }
    
}
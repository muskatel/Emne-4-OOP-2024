namespace ConsoleCalc;

public class Division: Calculation
{
    public override bool AssignNumber2(double num2)
    {
        if (num2 == 0)
        {
            ErrorMessage = "Cannot divide by zero.";
            return false;
        }
        
        return base.AssignNumber2(num2);
    }

    public override double PerformCalculation()
    {
        return num1 / num2;
    }
    
    public override string ToString()
    {
        return "/";
    }
}
namespace ConsoleCalc;

public class Subtraction: Calculation
{
    public override double PerformCalculation()
    {
        return num1 - num2;
    }
    
    public override string ToString()
    {
        return "-";
    }
}
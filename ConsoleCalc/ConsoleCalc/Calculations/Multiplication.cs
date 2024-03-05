namespace ConsoleCalc;

public class Multiplication: Calculation
{
    public override double PerformCalculation()
    {
        return num1 * num2;
    }
    
    public override string ToString()
    {
        return "x";
    }
}
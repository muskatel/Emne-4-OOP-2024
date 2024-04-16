namespace GradeAnalyzer;

public class Grade
{
    public int value;


    public string GradetoCharacter()
    {
        if (value >= 80)
        {
            return "A";
        }
        else if (value >= 70)
        {
            return "B";
        }
        else if (value >= 60)
        {
            return "C";
        }
        else if (value >= 50)
        {
            return "D";
        }
        else if (value >= 40)
        {
            return "E";
        }
        else
        {
            return "F";
        }
    }
    
    public string GradetoPF()
    {
        if (value > 50)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}
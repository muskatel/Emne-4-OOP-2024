namespace FilterExample;

public class Result
{
    public string name;
    public float grade;
    public Result(string name, float grade)
    {
        this.name = name;
        this.grade = grade;
    }
}

public class GradingTool
{
    public delegate bool FilterDelegate(float value);
    
    
    
    public void ExecuteOrder66()
    {
        List<Result> gradesList = new List<Result>();
        
        gradesList.Add(new Result("Steeve", 99));
        gradesList.Add(new Result("Stevo", 89));
        gradesList.Add(new Result("Stevus", 79));
        gradesList.Add(new Result("Steph", 69));
        gradesList.Add(new Result("Steever", 59));
        gradesList.Add(new Result("Robert (pronounced \"Steve\")", 49));
        gradesList.Add(new Result("Esteveabeth", 39));
        gradesList.Add(new Result("Mari", 29));
        gradesList.Add(new Result("Evev", 19));
        gradesList.Add(new Result("Eve", 9));
        gradesList.Add(new Result("Eveee", 66));
        gradesList.Add(new Result("Lina", 80));
        gradesList.Add(new Result("Alex", 75));


        FilterDelegate filterOver70 = FilterMaker(70);
        
        PrintGrade(FilterResults(gradesList, FilterMaker(25)));
    }

    public bool FilterOver50(float grade)
    {
        return grade >= 50;
    }
    
    public bool FilterOver40(float grade)
    {
        return grade >= 40;
    }

    /// <summary>
    /// Creates a new filter delegate based on input value
    /// </summary>
    /// <param name="value"></param>
    /// <returns> A filter that filter selects values over the input value</returns>
    public FilterDelegate FilterMaker(float value)
    {
        FilterDelegate filter = ((float input) =>
        {
            return input > value;
        } );
        
        return filter;
        
        // Shorthand
        // return input => input > value;
    }
    
    
    public List<Result> FilterResults(List<Result> results, FilterDelegate filter)
    {
        List<Result> output = new List<Result>();
        foreach (Result r in results)
        {
            if (filter(r.grade))
            {
                output.Add(r);
            }
        }

        return output;
    }

    public void PrintGrade(List<Result> results)
    {
        foreach (Result r in results)
        {
            Console.WriteLine($"{r.name} => {r.grade} ");
        }
    }
}
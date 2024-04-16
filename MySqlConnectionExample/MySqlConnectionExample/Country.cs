namespace MySqlConnectionExample;

public class Country
{
    public String Code { get; set; }
    public String Name { get; set; }
    public String Continent { get; set; }
    public String Region { get; set; }
    public double SurfaceArea { get; set; }
    public int IndepYear { get; set; }
    public int Population { get; set; }
    public double LifeExpectancy { get; set; }
    public double GNP { get; set; }
    public double GNPOld { get; set; }
    public String LocalName { get; set; }
    public String GovernmentForm { get; set; }
    public String HeadOfState { get; set; }
    public int Capital { get; set; } // fk on city table
    public String Code2 { get; set; }
}
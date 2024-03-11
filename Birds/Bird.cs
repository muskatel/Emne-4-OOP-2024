namespace Birds;

public abstract class Bird
{
    private string _commonName;
    private string _scientificName;

    protected Bird(string commonName, string scientificName)
    {
        _commonName = commonName;
        _scientificName = scientificName;
    }

    public override string ToString()
    {
        return $"{_commonName} ({_scientificName})";
    }
}
namespace Peoples;

// anything with pages and print
public class PrintedMedia
{
    private string _title;
    private int _numberOfPages;

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public int NumberOfPages
    {
        get => _numberOfPages;
        set => _numberOfPages = value;
    }

    public PrintedMedia(string title, int numberOfPages)
    {
        _title = title;
        _numberOfPages = numberOfPages;
    }

    public virtual int CountWords()
    {
        return _numberOfPages * 420;
    }
}
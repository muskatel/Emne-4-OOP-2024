namespace BookXample;

public class Book
{
    private String _title;
    public String Author { get; }
    public String ISBN;
    public String Publisher;
    public String Edition;
    public int NumberOfPages;
    
    public String Title
    {
        get
        {
            // some functionality here maybe?
            return _title;
        }
    }
    
    /// <summary>
    /// Create a book with a title only
    /// </summary>
    /// <param name="Title">The book title</param>
    public Book(String Title)
    {
        if (Title.Length == 0)
        {
            throw new Exception("Empty title");
        }
        
        _title = Title; // a book must have a title
    }
    
    public Book(String Title, String Author, String Publisher = "Self published")
    {
        
        _title = Title;
        this.Publisher = Publisher;
        this.Author = Author;
    }
    

    internal String Read(int pageNumber)
    {
        if (pageNumber > NumberOfPages)
        {
            
            return "page not found";
        }
        
        // return the page
        return "See Spot Run.";
    }
}


namespace Peoples;

public class Book:PrintedMedia
{
    private String isbn;
    private bool hardCover;
    public Book(string title, int numberOfPages, 
        string isbn, bool hardCover = false)
        :base(title,numberOfPages)
    {
        this.isbn = isbn;
        this.hardCover = hardCover;
    }

    public override int CountWords()
    {
        return (base.CountWords() * 7);
    }

    
        
    
}
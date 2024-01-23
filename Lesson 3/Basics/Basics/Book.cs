namespace Basics;

/// <summary>
/// Craig's Cool Book Class written for class!
/// </summary>
public class Book
{
    /// <summary>
    /// Book constructor
    /// </summary>
    /// <param name="name">The name of the book.</param>
    /// <param name="author">The book's author.</param>
    public Book(String name, String author)
    {
        this.name = name;
        this.author = author;
    }

    /// <summary>
    /// Prints a label for a book
    /// </summary>
    /// <returns>The authors name and then the book title as a compound string.</returns>
    public String PrintLabel()
    {
        String label = "";
        label += author + " - " + name;
        return label;
    }
    
    // variable, of type string, called name, that is private
    private String name;
    
    // public getter for name
    public String Name
    {
        get => name;
        //set => name = value;
    }

    // variable, of type string, called author, that is private
    private String author;

    // public getter for author
    public String Author
    {
        get => author;
    }

    
}
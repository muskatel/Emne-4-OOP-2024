namespace BookExample;

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book()
        {
            Author = "Willian Golding",
            Title = "Lord of the Flies"
        };

        Console.WriteLine(myBook.Title);
        
        
        string Title = "Lord of the Flies";
        string Author = "William Golding";
        string ISBN = "978-0399501487";
        string Publisher = "Penguin Books";
        string Edition = "Hardcover";
        int NumberOfPages = 224;
        
        Console.WriteLine($"{Title} was written by {Author}");

        String[] TitlesArray = new String[]
        {
            "Lord of the Flies", 
            "The Hitchhiker's Guide to the Galaxy",
            "Ready Player One"
        };
        
        
        List<String> TitlesList =
        [
            "Lord of the Flies", 
            "The Hitchhiker's guide to the galaxy",
            "Ready Player One"
        ];
        

    }
}

public class Book
{
    private String _title;
    public String Author;
    public String ISBN;
    public String Publisher;
    public String Edition;
    public int NumberOfPages;

    public Book()
    {
        NumberOfPages = 1;
    }


    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }
}


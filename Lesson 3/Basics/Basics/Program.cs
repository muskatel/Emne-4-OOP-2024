namespace Basics;

class Program
{
    static void Main(string[] args)
    {
        /*
        // this name is only for me
        Book tac = new Book("Thinking as Computation","H. Levesque");
        //tac.Name = "Thinking as Computation";
        //tac.author = "H. Levesque";

        Book lotr1 = new Book("The Fellowship of the Ring", "J.R.R. Tolkien");
        Book lotr2 = new Book("The Two Towers", "J.R.R. Tolkien");
        Book lotr3 = new Book("Return of the King", "J.R.R. Tolkien");

        List<Book> myBooks = new List<Book>();
        myBooks.Add(lotr1);
        myBooks.Add(lotr2);
        myBooks.Add(lotr3);
        */
        
        List<Book> myBooks = new List<Book>();
        myBooks.Add(new Book("The Fellowship of the Ring", "J.R.R. Tolkien"));
        myBooks.Add(new Book("The Two Towers", "J.R.R. Tolkien"));
        myBooks.Add(new Book("Return of the King", "J.R.R. Tolkien"));
        myBooks.Add(new Book("The Hobbit", "J.R.R. Tolkien"));
        myBooks.Add(new Book("Thinking as Computation","H. Levesque"));

        // how to find a book by name
        // Console.WriteLine(myBooks.Find(book => book.Name == "The Hobbit").Name);
        
        
        foreach (Book book in myBooks)
        {
            if (book.Name.Contains("Ring"))
            {
                Console.WriteLine("Found a \"ring\" book");
                Console.WriteLine(book.PrintLabel());
            }
        }
        
    }
}
// See https://aka.ms/new-console-template for more information

namespace BookXample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Book myBook1 = new Book("The Fellowship of the Ring");
        myBook1.NumberOfPages = 5000;

        //myBook1.Title = "My Book";
        
        
        Console.WriteLine(myBook1.Read(3));
        Console.WriteLine("Title: " + myBook1.Title);
        
        Console.WriteLine(myBook1.GetHashCode());

        Book newBook = new Book("my cool book" ,"steve");
        
        Console.WriteLine(newBook);

            //newBook.Author = "craig";
    }
}


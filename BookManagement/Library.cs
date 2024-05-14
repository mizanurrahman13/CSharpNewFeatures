namespace BookManagement;

public class Library
{
    private List<Book> books;

    // Constructor
    public Library()
    {
        books = new List<Book>();
    }

    // Method to add book to library
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Method to remove book from library
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    // Method to display all books in library
    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Last Page: {book.LastPage}");
        }
    }
}

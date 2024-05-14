namespace BookManagement;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int LastPage { get; set; }

    public Book(string title, string content)
    {
        Title = title;
        Content = content;
        LastPage = 0; // Initial last page is set to 0
    }

    private void SetLastPage(int page)
    {
        LastPage = page;
    }
}

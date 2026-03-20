namespace WinFormsApp14;

public class Book
{
    public string title;
    public int pages;

    public Book(string title, int pages)
    {
        this.title = title;
        this.pages = pages;
    }

    public Book(int pages)
    {
        this.title = "Неизвестно";
        this.pages = pages;
    }

    public string GetInfo()
    {
        return "Книга: " + title + ", страниц: " + pages;
    }
    
}
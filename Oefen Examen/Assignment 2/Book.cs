public class Book{
    public readonly string Title;
    public readonly string Author;
    protected string Language;

    public Book(string title, string author, string language){
        Title = title;
        Author = author;
        Language = language;
    }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Language = "EN";
    }

    public virtual void PrintInfo(){
        Console.WriteLine($"Title: {Title}\n Author: {Author}\n Language: {Language}");
    }
}
public class EBook : Book{

    public EBook(string title, string author, string language) : base(title, author, language)
    {
    }

    public EBook(string title, string author) : base(title, author)
    {
        Language = "EN";
    }

    public void UpdateLanguage(string language){
        Language = language;
    }

    public override void PrintInfo(){
        Console.WriteLine($"base.PrintInfo()\nEBook");
    }

}
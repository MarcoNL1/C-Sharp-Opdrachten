public class Member : Person{

    public string Name {get {return base.Name + " (member)";}}
    protected int NumberOfBooksBorrowed {get; set;}

    public Member(string name, int age) : base(name, age)
    {
        NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(Book book){

        if (Name == null){}
        if (NumberOfBooksBorrowed < 3 && ){

            NumberOfBooksBorrowed += 1;
            Console.WriteLine($"{Name} has borrowed {book.Title} by {book.Author}");
        }

        if (NumberOfBooksBorrowed >= 3){

            Console.WriteLine($"{Name} has already borrowed the maximum number of books");
        }

        if (book is EBook){

            Console.WriteLine($"{Name} has borrowed the EBook {book.Title} by {book.Author}");
        }
    }

    public override string ToString(){

        return base.ToString() + $"\nBorrowed books: {NumberOfBooksBorrowed}";
    }
}
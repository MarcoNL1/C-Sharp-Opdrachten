public class Member : Person{

    public string Name {get {return base.Name + "(member)";}}
    protected int NumberOfBooksBorrowed {get; set;}

    public Member(){

        NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(){

        if (null){}
        if (NumberOfBooksBorrowed < 3){

            NumberOfBooksBorrowed += 1;
            Console.WriteLine($"{Name} has borrowed {Book.Title} by {Book.Author}");
        }

        if (NumberOfBooksBorrowed >= 3){

            Console.WriteLine($"{Name} has already borrowed the maximum number of books");
        }

        if (Book is EBook){

            Console.WriteLine($"{Name} has borrowed the EBook {EBook.Name} by {EBook.Author}");
        }
    }

    public override string ToString(){

        return base.ToString() + $"\nBorrowed books: {NumberOfBooksBorrowed}";
    }
}
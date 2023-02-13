public class Program
{
    public static void Main()
    {
        Console.WriteLine("First name? ");
        var firstName = Console.ReadLine();
        Console.WriteLine("Last name? ");
        var lastName = Console.ReadLine();

        DisplayName(firstName, lastName);
    }

    public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";
    public static void DisplayName(string firstName, string lastName) => Console.WriteLine($"{Name(firstName, lastName)}");
}
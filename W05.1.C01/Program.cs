class Program
{
    public static void Main()
    {
        Person p1 = new("John Doe");
        Student s1 = new("Jane Doe");
        
        Console.WriteLine(p1.Introduce());
        Console.WriteLine(s1.Introduce());
        Console.WriteLine(s1.Status());
        s1.Graduate();
        Console.WriteLine(s1.Status());
    }
}
public class Program
{
    public static void Main()
    {
        Square sq1 = new Square(5);
        Square sq2 = new Square(10);
        
        Console.WriteLine($"Side: {sq1.Side}");
        Console.WriteLine($"Area: {sq1.Area()}");
        Console.WriteLine($"Perimeter: {sq1.Perimeter()}");
        Console.WriteLine($"Side: {sq2.Side}");
        Console.WriteLine($"Area: {sq2.Area()}");
        Console.WriteLine($"Perimeter: {sq2.Perimeter()}");
    }
}
using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main()
    {
        PrintIsLeapYear(2000);
    }

    public static bool IsDivisibleBy(int int1, int int2)
    {
        return (int1 % int2 == 0 && int1 % 100 != 0) && int1 % 400 != 0;
    }

    public static bool IsLeapYear(int year)
    {
        return IsDivisibleBy(year, 4);
    }

    public static void PrintIsLeapYear(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}
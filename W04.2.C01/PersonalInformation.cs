static class PersonalInformation
{
    
    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }

    public static void PrintName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }

    public static void PrintName(char age, string years)
    {
        Console.WriteLine($"{age}. {years}");
    }

    public static int IncreaseSalary(int baseSalary)
    {
        baseSalary += 100;
        return baseSalary;
    }
    
    public static double IncreaseSalary(int salary, double increase)
    {
        var doubleSalary = Convert.ToDouble(salary);
        doubleSalary *= increase + 1;
        return doubleSalary;
    }
}
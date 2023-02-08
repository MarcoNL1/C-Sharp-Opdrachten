for (int i = 4; i >= 0; i--)
{
    Console.WriteLine("Enter your PIN");
    var pin = Console.ReadLine();

    if (pin == "1234")
    {
        Console.WriteLine("Correct!");
        break;
    }
    
    if (i == 1)
    {
        Console.WriteLine("Your pass is confiscated.");
        break;
    }
    
    else
    {
        Console.WriteLine($"{i - 1} attempts left");
        continue;
    }
}
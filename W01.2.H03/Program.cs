Console.WriteLine("Enter a starting number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an end number: ");
var endNumber = Convert.ToInt32(Console.ReadLine());

for (var number = startNumber; number <= endNumber; number++)
{
    if (number % 3 == 0 & number % 5 != 0)
    {
        Console.WriteLine("Fizz");
        continue;
    }

    if (number % 5 == 0 & number % 3 != 0)
    {
        Console.WriteLine("Buzz");
        continue;
    }

    if (number % 3 == 0 & number % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }

    else
    {
        Console.WriteLine(number);
    }
}
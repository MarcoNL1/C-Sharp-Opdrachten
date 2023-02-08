Console.WriteLine("What is the person's name?");
var name = Console.ReadLine();

for (int i = 0; i < 4; i++)
{
    switch (i)
    {
        case 2:
            Console.WriteLine($"Happy birthday dear {name}!");
            continue;
        default:
            Console.WriteLine("Happy birthday to you!");
            continue;
    }
}
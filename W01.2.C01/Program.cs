int money = 4;

while (money > 0)
{
    Console.WriteLine($"Money left: {money}");
    Console.WriteLine("Look around (1) or go in a ride (2)?");
    string userinput = Console.ReadLine();

    switch (userinput)
    {
        case "1":
            Console.WriteLine("Yay!");
            continue;
        case "2":
            money -= 1;
            Console.WriteLine("Wheee!");
            continue;
        default:
            continue;
    }
}

Console.WriteLine("Time to go home");

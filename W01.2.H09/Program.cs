Console.WriteLine("Time to play Guess The Number!");
Random rnd = new(0);

while (true)
{
    Console.WriteLine("Give the minimum number:");
    int minNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Give the maximum number:");
    int maxNumber = Convert.ToInt32(Console.ReadLine());

    if (minNumber == maxNumber)
    {
        Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
        maxNumber += 1;
    }

    else if (minNumber > maxNumber)
    {
        Console.WriteLine("The minimum is higher than the maximum. Switching values.");
        minNumber = maxNumber;
        maxNumber = minNumber;
    }

    int randNumber = rnd.Next(minNumber, maxNumber);

    while (true)
    {
        Console.WriteLine($"Guess the number [{minNumber}-{maxNumber}]");
        int numberGuess = Convert.ToInt32(Console.ReadLine());

        if (int.TryParse(Console.ReadLine(), out numberGuess) == false)
        {
            continue;
        }

        if (numberGuess < randNumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (numberGuess > randNumber)
        {
            Console.WriteLine("Lower!");
        }

        else if (numberGuess == randNumber)
        {
            Console.WriteLine($"{numberGuess} is correct!");
            break;
        }

        Console.WriteLine("Do you wish to play another round? Y to continue");
        string playAgain = Console.ReadLine().ToLower();

        if (playAgain == "y")
        {
            continue;
        }

        Console.WriteLine("Thank you for playing!");
        break;
    }
}

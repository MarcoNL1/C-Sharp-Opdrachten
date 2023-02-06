Console.WriteLine("What direction would you like to go?\nUp\nDown\nRight\nLeft");
string direction = Console.ReadLine().ToLower();

switch (direction)
{
    case "up":
        Console.WriteLine("Current position\nX:0, Y:1");
        break;
    case "down":
        Console.WriteLine("Current position\nX:0, Y:-1");
        break;
    case "right":
        Console.WriteLine("Current position\nX:1, Y:0");
        break;
    case "left":
        Console.WriteLine("Current position\nX:-1, Y:0");
        break;
    default:
        Console.WriteLine("Invalid direction");
        break;
    
}


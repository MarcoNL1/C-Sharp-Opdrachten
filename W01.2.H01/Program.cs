Console.WriteLine("What is the amount to pay?");
var payAmount = Convert.ToInt32(Console.ReadLine());

while (payAmount > 0)
{
    Console.WriteLine($"\n{payAmount} left to pay");
    Console.WriteLine("Pay how much?");
    Console.WriteLine("1: 5\n 2: 10\n 3: 20\n 4: 50");
    var userPay = Console.ReadLine();

    switch (userPay)
    {
        case "1":
            payAmount -= 5;
            continue;
        case "2":
            payAmount -= 10;
            continue;
        case "3":
            payAmount -= 20;
            continue;
        case "4":
            payAmount -= 50;
            continue;
        default:
            continue;
    }
}

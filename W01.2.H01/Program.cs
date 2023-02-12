Console.WriteLine("What is the amount to pay?");
var amountToPay = Console.ReadLine();
var payAmount = Convert.ToInt32(amountToPay);

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

while (true)
{
    if (payAmount == 0)
    {
        Console.WriteLine($"You have paid {amountToPay}");
        break;
    }
    
    if (payAmount < 0)
    {
            Console.WriteLine($"You paid {payAmount * -1} too much. Give a tip? y/n");
            var tip = Console.ReadLine().ToLower();
            
            if (tip == "y")
            {
                Console.WriteLine($"You have paid {Convert.ToInt32(amountToPay) + payAmount * -1}");
                break;
            }
            if (tip == "n")
            {
                Console.WriteLine($"You have paid {amountToPay}");
                break;
            }
    }
}

using System;

class Taxes
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your balance?");
        double balance = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("What is the intrest rate?");
        double interestRate = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("How many years?");
        int years = Convert.ToInt32(Console.ReadLine());
        
        double totalTaxes = 0;
        
        for (int year = 1; year <= years; year++)
        {
            balance += balance * (interestRate/100);
            double tax = 0;
            switch (balance)
            {
                case > 100000:
                    tax = ((balance - 100000) * 0.03) + (50000 * 0.015);
                    break;
                case > 50000:
                    tax = (balance - 50000) * 0.015;
                    break;
            }
            totalTaxes += tax;
            balance -= tax;
        }
        Console.WriteLine($"Balance after {years} years: {(int) balance}");
        Console.WriteLine($"Amount of taxes paid: {(int) totalTaxes}");
    }
}
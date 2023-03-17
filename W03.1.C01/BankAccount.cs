public class BankAccount
{
    public static double InterestRatePercentage;
    public double Balance;

    public void Deposit(double money)
    {
        Balance += money;
    }

    public void ApplyInterest()
    {
        Balance +=  InterestRatePercentage;
    }
}
public class BankAccount
{
    private double _balance;
    protected int YearsPassed;
    protected double InterestRate;

    public BankAccount(double balance, double interestRate)
    {
        _balance = balance;
        InterestRate = interestRate;
        YearsPassed = 0;
    }

    public double ReadBalance()
    {
        return _balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0) _balance += amount;
    }

    public virtual double Withdraw(double amount)
    {
        if (SufficientBalance(amount) == false || amount < 0) return 0;
        _balance -= amount;
        return amount;

    }

    private bool SufficientBalance(double amount)
    {
        if (_balance >= amount) return true;
        return false;
    }

    protected virtual void ApplyInterest()
    {
        _balance += (_balance * InterestRate);
    }

    public virtual void NextYear()
    {
        ApplyInterest();
    }
}
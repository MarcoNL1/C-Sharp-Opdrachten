public class SavingsAccount : BankAccount
{
    private bool _locked;

    public SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
    {
        _locked = true;
    }

    public override double Withdraw(double amount)
    {
        if (_locked) return 0;
        return base.Withdraw(amount);
    }

    public override void NextYear()
    {
        YearsPassed += 1;
        if (YearsPassed < 5)
        {
            base.NextYear();
        }
        else
        {
            _locked = false;
        }
        
    }
}